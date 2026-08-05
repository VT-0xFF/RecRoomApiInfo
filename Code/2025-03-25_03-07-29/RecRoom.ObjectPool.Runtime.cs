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
		[Cpp2IlInjected.Address(RVA = "0x7B49850", Offset = "0x7B48C50", VA = "0x187B49850")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles FAHGNPJKBFP, float IKLKEOODEFI, Vector3 JPKKPDPLAGA, Quaternion BENMKDDDBDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B494F0", Offset = "0x7B488F0", VA = "0x187B494F0")]
		public void SetDamageValue(float IKLKEOODEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B49990", Offset = "0x7B48D90", VA = "0x187B49990")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AHEMLJCCAAE<T> : COLCOEKKCIF<T>, KMDOHMPCNFD, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OCPCDGOBKLP<T> : KMDOHMPCNFD, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FNNAAPMBCGG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EGIEKHGLFOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OODKGFCDEDH<T> : BFDPABAFKOD<T>, AHEMLJCCAAE<T>, COLCOEKKCIF<T>, KMDOHMPCNFD, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ABEPLEFFMMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public OODKGFCDEDH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public ABEPLEFFMMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x47EC7F0", Offset = "0x47EBBF0", VA = "0x1847EC7F0")]
			internal void GLDKGICDEPL(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x38DF1D0", Offset = "0x38DE5D0", VA = "0x1838DF1D0")]
			internal void KMPMPAEMPPM(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FHGKGMPNNBH<T> CHMHKBOPBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool PDLEDFJPEEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T MOAEMAHGOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool MIGDMPFDAHI;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x51EB3A0", Offset = "0x51EA7A0", VA = "0x1851EB3A0")]
		public OODKGFCDEDH(FHGKGMPNNBH<T> CHMHKBOPBGH, ObjectPool PDLEDFJPEEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x51EB230", Offset = "0x51EA630", VA = "0x1851EB230", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class GCLJIMHFPHB<T> : HBLFBFLDLLK, OCPCDGOBKLP<T>, KMDOHMPCNFD, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class MKGDFOCMOMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public GCLJIMHFPHB<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public MKGDFOCMOMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4F9A920", Offset = "0x4F99D20", VA = "0x184F9A920")]
			internal void GLDKGICDEPL(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x12F37B0", Offset = "0x12F2BB0", VA = "0x1812F37B0")]
			internal void KMPMPAEMPPM(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private FHGKGMPNNBH<T> CHMHKBOPBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool MIGDMPFDAHI;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x48149D0", Offset = "0x4813DD0", VA = "0x1848149D0")]
		public GCLJIMHFPHB(FHGKGMPNNBH<T> CHMHKBOPBGH, ObjectPool PDLEDFJPEEP, int PGPANGPPELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4814970", Offset = "0x4813D70", VA = "0x184814970", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OBDDOHBKOAI<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EGIEKHGLFOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public BFDPABAFKOD<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FHGKGMPNNBH<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public OBDDOHBKOAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5139F80", Offset = "0x5139380", VA = "0x185139F80")]
		internal void PJJLHABKKLE(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5139F20", Offset = "0x5139320", VA = "0x185139F20")]
		internal void JBHFNIDOGCE(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5139ED0", Offset = "0x51392D0", VA = "0x185139ED0")]
		internal void HFGKEDHAEFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<FNNAAPMBCGG> HHMIKJFFAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private MMOGIHLNNJJ FCLFBAHDMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool PDLEDFJPEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool MIGDMPFDAHI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B47DF0", Offset = "0x7B471F0", VA = "0x187B47DF0")]
	private static void EHFGLFHNJKL(Component EJFPPCHJOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7B48390", Offset = "0x7B47790", VA = "0x187B48390")]
	public EGIEKHGLFOH(string FAGNIGAMDJK, int FBGPCNLEHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x343CDA0", Offset = "0x343C1A0", VA = "0x18343CDA0")]
	public AHEMLJCCAAE<T> GOPOIGEKMOO<T>(AssetReference IIBHKFHELIO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x343CE70", Offset = "0x343C270", VA = "0x18343CE70")]
	public OCPCDGOBKLP<T> JFIBBLIHGAO<T>(AssetReference IIBHKFHELIO, int PPLOBPJCNII) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x343CF50", Offset = "0x343C350", VA = "0x18343CF50")]
	public COLCOEKKCIF<bool> OECMCOFHLAA<T>(AssetReference IIBHKFHELIO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B47D00", Offset = "0x7B47100", VA = "0x187B47D00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B48030", Offset = "0x7B47430", VA = "0x187B48030")]
	private void EIPLDMDCNLF(UnityEngine.Object ICECCHJNOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7B48170", Offset = "0x7B47570", VA = "0x187B48170")]
	private ObjectPool PFNJBIODMAD(string FAGNIGAMDJK)
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
		private static GlobalPool JOAALLKFIIK;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject IDAHIKEGAOO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool DMADMDPHOOL
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7B486F0", Offset = "0x7B47AF0", VA = "0x187B486F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x35CBE60", Offset = "0x35CB260", VA = "0x1835CBE60")]
		public static void SafeRelease<T>(T HAPOBHMBDHP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B48620", Offset = "0x7B47A20", VA = "0x187B48620")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7B486E0", Offset = "0x7B47AE0", VA = "0x187B486E0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, NJKBAEILDAD> EPMOPKLHJFH;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x37D7F40", Offset = "0x37D7340", VA = "0x1837D7F40")]
		public T Acquire<T>(T FAHGNPJKBFP, [Optional] Action<Component> MFJNFPJPAGC) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x37D8300", Offset = "0x37D7700", VA = "0x1837D8300")]
		public bool Release<T>(T HAPOBHMBDHP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x37D8290", Offset = "0x37D7690", VA = "0x1837D8290")]
		public void Prefill<T>(T FAHGNPJKBFP, int LGDLDGONMCG, [Optional] Action<Component> NKOHIDJPMJP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x37D80B0", Offset = "0x37D74B0", VA = "0x1837D80B0")]
		public bool Exists<T>(T FAHGNPJKBFP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x37D8000", Offset = "0x37D7400", VA = "0x1837D8000")]
		public void Clear<T>(T FAHGNPJKBFP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7B490B0", Offset = "0x7B484B0", VA = "0x187B490B0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x37D8150", Offset = "0x37D7550", VA = "0x1837D8150")]
		private NJKBAEILDAD GMGILGDNKAN<T>(T FAHGNPJKBFP) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
		public void TrackInstantiation(string ALEGPPGJOPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
		public void EnableStats(bool FFHAOPDCFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7B49220", Offset = "0x7B48620", VA = "0x187B49220")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class NJKBAEILDAD
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GFMNIBPNMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DAMAGIBBMFF(bool GIPGMKNGIBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int DJPCOFDMJPG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void JFIBBLIHGAO(int PPLOBPJCNII, Action<Component> NKOHIDJPMJP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component GOPOIGEKMOO(Action<Component> MFJNFPJPAGC);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool ICCKCAPBKGG(Component DBFKLCEDAMM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void GAPBPDEBKKO();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B48BB0", Offset = "0x7B47FB0", VA = "0x187B48BB0")]
	protected void HLHAFIKLCCE(Component HAPOBHMBDHP, bool GIPGMKNGIBJ, bool EGEHDJFPDLL, bool HOBECEGIOOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7B48930", Offset = "0x7B47D30", VA = "0x187B48930")]
	protected void BCAEMKBFIIA(Transform DAMAOEMOOHE, bool GIPGMKNGIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	protected NJKBAEILDAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MCIPGLPOEGF<T> : NJKBAEILDAD where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T FAHGNPJKBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool KCDMJHKFOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool EGEHDJFPDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> JNDLHDMIBPP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4F65EA0", Offset = "0x4F652A0", VA = "0x184F65EA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int DJPCOFDMJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4F65D20", Offset = "0x4F65120", VA = "0x184F65D20", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4F65EC0", Offset = "0x4F652C0", VA = "0x184F65EC0")]
	public MCIPGLPOEGF(T FAHGNPJKBFP, ObjectPool KCDMJHKFOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4F65D70", Offset = "0x4F65170", VA = "0x184F65D70", Slot = "6")]
	public override void JFIBBLIHGAO(int PPLOBPJCNII, Action<Component> MFJNFPJPAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4F658E0", Offset = "0x4F64CE0", VA = "0x184F658E0", Slot = "7")]
	public override Component GOPOIGEKMOO(Action<Component> MFJNFPJPAGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4F65B70", Offset = "0x4F64F70", VA = "0x184F65B70", Slot = "8")]
	public override bool ICCKCAPBKGG(Component DBFKLCEDAMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4F656D0", Offset = "0x4F64AD0", VA = "0x184F656D0", Slot = "9")]
	public override void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4F65510", Offset = "0x4F64910", VA = "0x184F65510")]
	private T FEAMADCLBFF()
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
		public interface MGCMBHCPCJJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject MNADIBKJKNO
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
		[Cpp2IlInjected.Address(RVA = "0x7B48D30", Offset = "0x7B48130", VA = "0x187B48D30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7B49020", Offset = "0x7B48420", VA = "0x187B49020")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool JOAALLKFIIK;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject IDAHIKEGAOO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool DMADMDPHOOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7B49370", Offset = "0x7B48770", VA = "0x187B49370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7B492B0", Offset = "0x7B486B0", VA = "0x187B492B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7B486E0", Offset = "0x7B47AE0", VA = "0x187B486E0")]
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
		public NJKBAEILDAD PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DFKKNHBMIHN
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MAEIOAKAFGB(PooledParticle.LIDAPOOGCCL LPMLMMNKNGK);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum GHNOPJHBPBL
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
		public enum LIDAPOOGCCL
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
		public interface GMGJBPAIHOO
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool IBMPLHDLMJE
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 GJDMNCIKBAD
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera GGCOCEJJEFH
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
			[Cpp2IlInjected.Address(RVA = "0x6873660", Offset = "0x6872A60", VA = "0x186873660")]
			public ColorConfiguration(ParticleSystem KFJFHJOOPMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7B47490", Offset = "0x7B46890", VA = "0x187B47490")]
			public void HJILODOODPL(Color CKANMCILFBE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class KJOKLEEDNMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public KJOKLEEDNMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7B48900", Offset = "0x7B47D00", VA = "0x187B48900")]
			internal void BNNDGINHIJO(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class DFIMJEFFPGC : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private OAGIBKDGOAG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private GMGJBPAIHOO <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
			[DebuggerHidden]
			public DFIMJEFFPGC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7B47680", Offset = "0x7B46A80", VA = "0x187B47680", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7B47CB0", Offset = "0x7B470B0", VA = "0x187B47CB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class HMPFMGIIIKD : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private OAGIBKDGOAG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
			[DebuggerHidden]
			public HMPFMGIIIKD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7B48840", Offset = "0x7B47C40", VA = "0x187B48840", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7B488B0", Offset = "0x7B47CB0", VA = "0x187B488B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> DDNKKACKDEM;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Lazy<DFKKNHBMIHN> PCABNMOJLFO;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static List<PooledParticle> JEOKDHHCCNI;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static INGHODAMJIF LBGDFHJOJPL;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float IEOHPPIBACC = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static bool OBHKKAAGHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected int LEAJBHKJJEH;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private LIDAPOOGCCL category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float? DKOFGAPLDOC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ParticleSystem.MinMaxGradient[] LEDPMGFLLON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool GCBGEAMLCII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float EICOKGPAPJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float BMDKNGOEIKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Transform EODDFHEPDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Vector3 HGOKJONIPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Vector3 GACANIDNNLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private GHNOPJHBPBL KPCEFKPGNOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private INGHODAMJIF HEGBAFLENDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected bool LJHAAKCGLAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Transform PKFFAABMEKJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> DPIMCPNJIIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7B4D630", Offset = "0x7B4CA30", VA = "0x187B4D630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public LIDAPOOGCCL KMEHNAKHHCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9B9CD0", Offset = "0x9B90D0", VA = "0x1809B9CD0")]
			get
			{
				return default(LIDAPOOGCCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int MHOJDFGANPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x991DB0", Offset = "0x9911B0", VA = "0x180991DB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NNPJNNGBNIF
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7B4D370", Offset = "0x7B4C770", VA = "0x187B4D370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int BHJLNPBDACP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7B4D4E0", Offset = "0x7B4C8E0", VA = "0x187B4D4E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool OFABHHOOEGM
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7B4AAD0", Offset = "0x7B49ED0", VA = "0x187B4AAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem BKFGMHEGHDA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x99BAC0", Offset = "0x99AEC0", VA = "0x18099BAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] AJKCJPNKGJF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x991DA0", Offset = "0x9911A0", VA = "0x180991DA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] DOCIHCEDFAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x993560", Offset = "0x992960", VA = "0x180993560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private GHNOPJHBPBL NLHKAENBFLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x99A8B0", Offset = "0x999CB0", VA = "0x18099A8B0")]
			get
			{
				return default(GHNOPJHBPBL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7B4B430", Offset = "0x7B4A830", VA = "0x187B4B430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform NPHMCHFKJHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7B4D680", Offset = "0x7B4CA80", VA = "0x187B4D680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action DFDONCICAHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7B4D2D0", Offset = "0x7B4C6D0", VA = "0x187B4D2D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7B4D6D0", Offset = "0x7B4CAD0", VA = "0x187B4D6D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B4CD10", Offset = "0x7B4C110", VA = "0x187B4CD10")]
		public static PooledParticle TryPlayPrefab(PooledParticle FAHGNPJKBFP, Vector3 JPKKPDPLAGA, Quaternion BENMKDDDBDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B4CE30", Offset = "0x7B4C230", VA = "0x187B4CE30")]
		public static PooledParticle TryPlayPrefab(PooledParticle FAHGNPJKBFP, Vector3 JPKKPDPLAGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7B4C300", Offset = "0x7B4B700", VA = "0x187B4C300")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7B4AEC0", Offset = "0x7B4A2C0", VA = "0x187B4AEC0")]
		private void LFIBGPLNNEL(bool ODCIGAJHLFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4AF90", Offset = "0x7B4A390", VA = "0x187B4AF90")]
		[IteratorStateMachine(typeof(DFIMJEFFPGC))]
		private static IEnumerator<OAGIBKDGOAG> LHMKCNLEAPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A2F0", Offset = "0x7B496F0", VA = "0x187B4A2F0")]
		private static void GIBHBAIDHKF(Stopwatch AOBIHHLEODI, Vector3 HDJKJAAGGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7B4AA20", Offset = "0x7B49E20", VA = "0x187B4AA20")]
		private static int IIFKIEJEEKC(PooledParticle ONMPMLDKLEL, PooledParticle CEMDANFAAHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7B4B320", Offset = "0x7B4A720", VA = "0x187B4B320")]
		private static int MAEIOAKAFGB(LIDAPOOGCCL LPMLMMNKNGK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7B4B450", Offset = "0x7B4A850", VA = "0x187B4B450")]
		protected void NCOPCAMGKAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7B49CE0", Offset = "0x7B490E0", VA = "0x187B49CE0")]
		protected void CDGEFOHKGNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7B49A70", Offset = "0x7B48E70", VA = "0x187B49A70", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7B4AFF0", Offset = "0x7B4A3F0", VA = "0x187B4AFF0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B4B640", Offset = "0x7B4AA40", VA = "0x187B4B640")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7B4AB50", Offset = "0x7B49F50", VA = "0x187B4AB50")]
		[IteratorStateMachine(typeof(HMPFMGIIIKD))]
		private IEnumerator<OAGIBKDGOAG> KAMNGBLBICA(float DAJECHOKOMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A8C0", Offset = "0x7B49CC0", VA = "0x187B4A8C0")]
		private void ICCKCAPBKGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7B4CA50", Offset = "0x7B4BE50", VA = "0x187B4CA50")]
		public void SetDuration(float DAJECHOKOMD, bool IJPMNMIOHEG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7B4B6D0", Offset = "0x7B4AAD0", VA = "0x187B4B6D0")]
		public void Play(Transform DNELIDFJCKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B4BF70", Offset = "0x7B4B370", VA = "0x187B4BF70")]
		public void Play(Transform DNELIDFJCKN, bool BLEOONECPMM, float GANFDPPPBPH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7B4B820", Offset = "0x7B4AC20", VA = "0x187B4B820")]
		public void Play(Transform DNELIDFJCKN, Vector3 GACANIDNNLI, bool BLEOONECPMM, float GANFDPPPBPH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7B4B970", Offset = "0x7B4AD70", VA = "0x187B4B970")]
		public void Play(Transform LCHBDNEIGOF, Quaternion BENMKDDDBDG, bool BLEOONECPMM = false, float GANFDPPPBPH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4C0E0", Offset = "0x7B4B4E0", VA = "0x187B4C0E0")]
		public void Play(Transform LCHBDNEIGOF, Vector3 GACANIDNNLI, Quaternion BENMKDDDBDG, bool BLEOONECPMM = false, float GANFDPPPBPH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4BC10", Offset = "0x7B4B010", VA = "0x187B4BC10")]
		public void Play(Vector3 JPKKPDPLAGA, Quaternion BENMKDDDBDG, Vector3 APPPFHHBPEI, bool BLEOONECPMM = false, float GANFDPPPBPH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7B4BAB0", Offset = "0x7B4AEB0", VA = "0x187B4BAB0")]
		public void Play(Vector3 JPKKPDPLAGA, Quaternion BENMKDDDBDG, bool BLEOONECPMM = false, float GANFDPPPBPH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7B4BD90", Offset = "0x7B4B190", VA = "0x187B4BD90")]
		public void Play(bool BLEOONECPMM = false, float GANFDPPPBPH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7B4CC70", Offset = "0x7B4C070", VA = "0x187B4CC70")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4CB20", Offset = "0x7B4BF20", VA = "0x187B4CB20")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B4AD20", Offset = "0x7B4A120", VA = "0x187B4AD20")]
		private void KPIPCBJLCCN(float DAJECHOKOMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7B4ABE0", Offset = "0x7B49FE0", VA = "0x187B4ABE0")]
		private void KDOIHIOFHGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7B4C210", Offset = "0x7B4B610", VA = "0x187B4C210")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7B4C480", Offset = "0x7B4B880", VA = "0x187B4C480")]
		public void SetColor(Color CKANMCILFBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A6D0", Offset = "0x7B49AD0", VA = "0x187B4A6D0")]
		private void HOHOJEFEOBH(float? AKIEJPDFOGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A660", Offset = "0x7B49A60", VA = "0x187B4A660")]
		private void HEIENEPKPCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A790", Offset = "0x7B49B90", VA = "0x187B4A790")]
		private void IBIGOAOLHEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7B4D240", Offset = "0x7B4C640", VA = "0x187B4D240")]
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
