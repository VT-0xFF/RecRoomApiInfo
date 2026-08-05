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
		[Cpp2IlInjected.Address(RVA = "0x5ED5840", Offset = "0x5ED4C40", VA = "0x185ED5840")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles BDNIDEKLIGD, float PPJNGOGCEHC, Vector3 BAONBICGOEJ, Quaternion CKFJFCLIANA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5ED54E0", Offset = "0x5ED48E0", VA = "0x185ED54E0")]
		public void SetDamageValue(float PPJNGOGCEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5ED59C0", Offset = "0x5ED4DC0", VA = "0x185ED59C0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DBHNEBLIIKA<T> : DMGBOCKAFMH<T>, IKPLFJCHDDD, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EIGCPCOEBJG<T> : IKPLFJCHDDD, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BDGFLFPDEBA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LINLLGGLPJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class LJGHFDGOLNM<T> : BOLHGOALIJH<T>, DBHNEBLIIKA<T>, DMGBOCKAFMH<T>, IKPLFJCHDDD, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BOEBCMGNAIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public LJGHFDGOLNM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public BOEBCMGNAIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x44E3200", Offset = "0x44E2600", VA = "0x1844E3200")]
			internal void KAFCKKHAIGB(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1FF1DF0", Offset = "0x1FF11F0", VA = "0x181FF1DF0")]
			internal void PKPHNOABFCP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EGHLOMAONPH<T> KFJFFCBMIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool KGBDICDHAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T CLFOAALEFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool LDCMHPNHJNB;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x38EE820", Offset = "0x38EDC20", VA = "0x1838EE820")]
		public LJGHFDGOLNM(EGHLOMAONPH<T> KFJFFCBMIGN, ObjectPool KGBDICDHAOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x38EE6E0", Offset = "0x38EDAE0", VA = "0x1838EE6E0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class NKGFOBLPKGN<T> : NMHMFMOCBJF, EIGCPCOEBJG<T>, IKPLFJCHDDD, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class JBPLKKJGBEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NKGFOBLPKGN<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public JBPLKKJGBEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3772490", Offset = "0x3771890", VA = "0x183772490")]
			internal void KAFCKKHAIGB(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8897D0", Offset = "0x888BD0", VA = "0x1808897D0")]
			internal void PKPHNOABFCP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private EGHLOMAONPH<T> KFJFFCBMIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool LDCMHPNHJNB;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3740", Offset = "0x3BE2B40", VA = "0x183BE3740")]
		public NKGFOBLPKGN(EGHLOMAONPH<T> KFJFFCBMIGN, ObjectPool KGBDICDHAOK, int HPHJLDDAKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3BE36E0", Offset = "0x3BE2AE0", VA = "0x183BE36E0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BGKHJMBLINO<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LINLLGGLPJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public BOLHGOALIJH<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EGHLOMAONPH<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public BGKHJMBLINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x44A4B90", Offset = "0x44A3F90", VA = "0x1844A4B90")]
		internal void CMNDNLDLDIN(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x44A4C90", Offset = "0x44A4090", VA = "0x1844A4C90")]
		internal void MBNMJKIGEHD(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x44A4C40", Offset = "0x44A4040", VA = "0x1844A4C40")]
		internal void LIAHIFHIPIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<BDGFLFPDEBA> GPLEHFKIFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private ENALMGPGAGD HIFJBHIPECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool KGBDICDHAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool JDOCCLKLOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4770", Offset = "0x5ED3B70", VA = "0x185ED4770")]
	private static void ODOBNNPECEA(Component FNPIKAPNGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4A40", Offset = "0x5ED3E40", VA = "0x185ED4A40")]
	public LINLLGGLPJK(string BJCOOPFBLAC, int LEHMPFCFEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x244DD30", Offset = "0x244D130", VA = "0x18244DD30")]
	public DBHNEBLIIKA<T> FNHFAFDBPDO<T>(AssetReference CNJLKMANIKG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x244DDD0", Offset = "0x244D1D0", VA = "0x18244DDD0")]
	public EIGCPCOEBJG<T> HDAEFHNJFJF<T>(AssetReference CNJLKMANIKG, int CHEGLPEPHED) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x244DE80", Offset = "0x244D280", VA = "0x18244DE80")]
	public DMGBOCKAFMH<bool> NDBJGAPFHCF<T>(AssetReference CNJLKMANIKG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED43C0", Offset = "0x5ED37C0", VA = "0x185ED43C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4640", Offset = "0x5ED3A40", VA = "0x185ED4640")]
	private void JPHCPBGKBON(UnityEngine.Object ONDNNFFBPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED44B0", Offset = "0x5ED38B0", VA = "0x185ED44B0")]
	private ObjectPool IAAGJHPMLDL(string BJCOOPFBLAC)
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
		private static GlobalPool DIEMHDFFECD;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject ECBBBLDDGPO;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool OMCMBELJBID
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5ED3BF0", Offset = "0x5ED2FF0", VA = "0x185ED3BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x23CC6D0", Offset = "0x23CBAD0", VA = "0x1823CC6D0")]
		public static void SafeRelease<T>(T IBBNLILJNEB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3B20", Offset = "0x5ED2F20", VA = "0x185ED3B20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3BE0", Offset = "0x5ED2FE0", VA = "0x185ED3BE0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, EIBKCOFBBDM> EACDBBHPNBP;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x253CA10", Offset = "0x253BE10", VA = "0x18253CA10")]
		public T Acquire<T>(T BDNIDEKLIGD, [Optional] Action<Component> JGMBLKFMEDB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x253CD80", Offset = "0x253C180", VA = "0x18253CD80")]
		public bool Release<T>(T IBBNLILJNEB) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x253CD30", Offset = "0x253C130", VA = "0x18253CD30")]
		public void Prefill<T>(T BDNIDEKLIGD, int DCEDLCHFJIH, [Optional] Action<Component> BHPOALOPFGM) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x253CC90", Offset = "0x253C090", VA = "0x18253CC90")]
		public bool Exists<T>(T BDNIDEKLIGD) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x253CAA0", Offset = "0x253BEA0", VA = "0x18253CAA0")]
		public void Clear<T>(T BDNIDEKLIGD) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5050", Offset = "0x5ED4450", VA = "0x185ED5050")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x253CB50", Offset = "0x253BF50", VA = "0x18253CB50")]
		private EIBKCOFBBDM ECCGHFNKDEL<T>(T BDNIDEKLIGD) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
		public void TrackInstantiation(string HDLEBHACCBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
		public void EnableStats(bool LKABHAEKHFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED51C0", Offset = "0x5ED45C0", VA = "0x185ED51C0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class EIBKCOFBBDM
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FBPJPLCGJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PKLAAIDKGFD(bool NGEFJHDPCLO);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int DFCMBIMEEHI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void HDAEFHNJFJF(int CHEGLPEPHED, Action<Component> BHPOALOPFGM);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component FNHFAFDBPDO(Action<Component> JGMBLKFMEDB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool AGCMPNGAPHP(Component ACIJMAHOIPB);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void OOAOJFKKMLN();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5ED39A0", Offset = "0x5ED2DA0", VA = "0x185ED39A0")]
	protected void IKAMDFGOPFF(Component IBBNLILJNEB, bool NGEFJHDPCLO, bool NCHGBIJADKJ, bool NJKOANEIPGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3720", Offset = "0x5ED2B20", VA = "0x185ED3720")]
	protected void ELADLMKLIFI(Transform BLFHIIGHKPE, bool NGEFJHDPCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	protected EIBKCOFBBDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AIAHLDECDHO<T> : EIBKCOFBBDM where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T BDNIDEKLIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool MPCNKHPDFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool NCHGBIJADKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> LCACGDGFHKE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x34CFCE0", Offset = "0x34CF0E0", VA = "0x1834CFCE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int DFCMBIMEEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x34CFCA0", Offset = "0x34CF0A0", VA = "0x1834CFCA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x34D03D0", Offset = "0x34CF7D0", VA = "0x1834D03D0")]
	public AIAHLDECDHO(T BDNIDEKLIGD, ObjectPool MPCNKHPDFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x34CFF70", Offset = "0x34CF370", VA = "0x1834CFF70", Slot = "6")]
	public override void HDAEFHNJFJF(int CHEGLPEPHED, Action<Component> JGMBLKFMEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x34CFD00", Offset = "0x34CF100", VA = "0x1834CFD00", Slot = "7")]
	public override Component FNHFAFDBPDO(Action<Component> JGMBLKFMEDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x34CFB00", Offset = "0x34CEF00", VA = "0x1834CFB00", Slot = "8")]
	public override bool AGCMPNGAPHP(Component ACIJMAHOIPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x34D01F0", Offset = "0x34CF5F0", VA = "0x1834D01F0", Slot = "9")]
	public override void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x34D0080", Offset = "0x34CF480", VA = "0x1834D0080")]
	private T NBPPHFMGBGH()
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
		public interface OINJKLLAFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject OHGMICICEOM
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
		[Cpp2IlInjected.Address(RVA = "0x5ED4CD0", Offset = "0x5ED40D0", VA = "0x185ED4CD0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4FC0", Offset = "0x5ED43C0", VA = "0x185ED4FC0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool DIEMHDFFECD;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject ECBBBLDDGPO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool OMCMBELJBID
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5ED5340", Offset = "0x5ED4740", VA = "0x185ED5340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5280", Offset = "0x5ED4680", VA = "0x185ED5280")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3BE0", Offset = "0x5ED2FE0", VA = "0x185ED3BE0")]
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
		public EIBKCOFBBDM PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EBNIBGIBAKA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HPHFMACOFAE(PooledParticle.JIMGDCOPBGL PHGDGAHAMDA);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum LEPPGELPCFI
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
		public enum JIMGDCOPBGL
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
		public interface GBFHABAGIHM
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool ELNOPHNBLHB
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 BLMCCEJMMJD
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera PEFJGJKNCHK
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
			[Cpp2IlInjected.Address(RVA = "0x501A9E0", Offset = "0x5019DE0", VA = "0x18501A9E0")]
			public ColorConfiguration(ParticleSystem CANEEPCLHDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5ED3530", Offset = "0x5ED2930", VA = "0x185ED3530")]
			public void CIEMKMHKCLO(Color KKBAHNFNJMK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class PBBINKLIMIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public PBBINKLIMIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5ED5250", Offset = "0x5ED4650", VA = "0x185ED5250")]
			internal void DIOFKOFLKGD(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class JHOPAEACFOH : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private AOAPPGOKEOI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private GBFHABAGIHM <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
			[DebuggerHidden]
			public JHOPAEACFOH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5ED3D60", Offset = "0x5ED3160", VA = "0x185ED3D60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5ED4370", Offset = "0x5ED3770", VA = "0x185ED4370", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class CBILHPKIMDO : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private AOAPPGOKEOI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
			[DebuggerHidden]
			public CBILHPKIMDO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5ED3470", Offset = "0x5ED2870", VA = "0x185ED3470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5ED34E0", Offset = "0x5ED28E0", VA = "0x185ED34E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> HNKKONEFJOJ;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<EBNIBGIBAKA> MFGCDKCANEI;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> MKFNPFDNJPF;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static GKKBBPDHGPP MIIPAMOMDFO;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float BLFGKEBGIDJ = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool IBJHMPLNBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int LNCONBBBFJO;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private JIMGDCOPBGL category;

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
		private ParticleSystem.MinMaxGradient[] OMMEABJAOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool FFKCMOGNLKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float INLNGIDPBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float IKMJFLLKEBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform NOKKKJFHNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 KJPHHBBDLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 AHKPHHNGCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private LEPPGELPCFI FOHINPDKBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private GKKBBPDHGPP PBBOLCMFLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool NGKBOPHMNBL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> OKCBFMOJMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5ED9210", Offset = "0x5ED8610", VA = "0x185ED9210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public JIMGDCOPBGL PEIHBJNOINP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x78B850", Offset = "0x78AC50", VA = "0x18078B850")]
			get
			{
				return default(JIMGDCOPBGL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int HFCNHNIJPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x765400", Offset = "0x764800", VA = "0x180765400")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool ENLBFFMNMKN
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5ED8F40", Offset = "0x5ED8340", VA = "0x185ED8F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int JFDDKPEIOIG
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5ED90C0", Offset = "0x5ED84C0", VA = "0x185ED90C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool MOKKEHJKFEM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5ED5C00", Offset = "0x5ED5000", VA = "0x185ED5C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem PENKABKKOMG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x767740", Offset = "0x766B40", VA = "0x180767740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x76DDB0", Offset = "0x76D1B0", VA = "0x18076DDB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] FJEOOBMGHLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A830", VA = "0x18076B430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] KAHOMMCBJMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766D70", VA = "0x180767970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x767760", Offset = "0x766B60", VA = "0x180767760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private LEPPGELPCFI FOBNAGIGNBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCC7890", Offset = "0xCC6C90", VA = "0x180CC7890")]
			get
			{
				return default(LEPPGELPCFI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5ED72D0", Offset = "0x5ED66D0", VA = "0x185ED72D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FBFAKAFKLAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5ED8EA0", Offset = "0x5ED82A0", VA = "0x185ED8EA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5ED9260", Offset = "0x5ED8660", VA = "0x185ED9260")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8830", Offset = "0x5ED7C30", VA = "0x185ED8830")]
		public static PooledParticle TryPlayPrefab(PooledParticle BDNIDEKLIGD, Vector3 BAONBICGOEJ, Quaternion CKFJFCLIANA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5ED89A0", Offset = "0x5ED7DA0", VA = "0x185ED89A0")]
		public static PooledParticle TryPlayPrefab(PooledParticle BDNIDEKLIGD, Vector3 BAONBICGOEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7EE0", Offset = "0x5ED72E0", VA = "0x185ED7EE0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5ED65A0", Offset = "0x5ED59A0", VA = "0x185ED65A0")]
		private void JFBOAGMFPOM(bool FAGLGPEMPJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6240", Offset = "0x5ED5640", VA = "0x185ED6240")]
		[IteratorStateMachine(typeof(JHOPAEACFOH))]
		private static IEnumerator<AOAPPGOKEOI> GNDEBHKJCBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6670", Offset = "0x5ED5A70", VA = "0x185ED6670")]
		private static void KILOKCEEAEN(Stopwatch LHJMFKIBCKM, Vector3 HDPNGJFNNJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED62A0", Offset = "0x5ED56A0", VA = "0x185ED62A0")]
		private static int HHCEHPMAFAO(PooledParticle IOJNHOGOOGI, PooledParticle IODCBCAEEGP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6350", Offset = "0x5ED5750", VA = "0x185ED6350")]
		private static int HPHFMACOFAE(JIMGDCOPBGL PHGDGAHAMDA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5EB0", Offset = "0x5ED52B0", VA = "0x185ED5EB0")]
		protected void EJKABMOKAGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED69C0", Offset = "0x5ED5DC0", VA = "0x185ED69C0")]
		protected void KNNABEGGPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5C80", Offset = "0x5ED5080", VA = "0x185ED5C80", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7060", Offset = "0x5ED6460", VA = "0x185ED7060")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5ED72F0", Offset = "0x5ED66F0", VA = "0x185ED72F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6FD0", Offset = "0x5ED63D0", VA = "0x185ED6FD0")]
		[IteratorStateMachine(typeof(CBILHPKIMDO))]
		private IEnumerator<AOAPPGOKEOI> LEIIPMBMGCB(float DGGLMJANNMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5AA0", Offset = "0x5ED4EA0", VA = "0x185ED5AA0")]
		private void AGCMPNGAPHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8640", Offset = "0x5ED7A40", VA = "0x185ED8640")]
		public void SetDuration(float DGGLMJANNMD, bool JCPOOODEFKP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5ED74A0", Offset = "0x5ED68A0", VA = "0x185ED74A0")]
		public void Play(Transform MGBFFJAELBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7B50", Offset = "0x5ED6F50", VA = "0x185ED7B50")]
		public void Play(Transform MGBFFJAELBO, bool IKIPPDPENJC, float NAEDHGDMMLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7600", Offset = "0x5ED6A00", VA = "0x185ED7600")]
		public void Play(Transform MGBFFJAELBO, Vector3 AHKPHHNGCHB, bool IKIPPDPENJC, float NAEDHGDMMLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7750", Offset = "0x5ED6B50", VA = "0x185ED7750")]
		public void Play(Transform IOJICBOHKBO, Quaternion CKFJFCLIANA, bool IKIPPDPENJC = false, float NAEDHGDMMLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7CC0", Offset = "0x5ED70C0", VA = "0x185ED7CC0")]
		public void Play(Transform IOJICBOHKBO, Vector3 AHKPHHNGCHB, Quaternion CKFJFCLIANA, bool IKIPPDPENJC = false, float NAEDHGDMMLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7970", Offset = "0x5ED6D70", VA = "0x185ED7970")]
		public void Play(Vector3 BAONBICGOEJ, Quaternion CKFJFCLIANA, Vector3 FJGOAHOCDJJ, bool IKIPPDPENJC = false, float NAEDHGDMMLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED78B0", Offset = "0x5ED6CB0", VA = "0x185ED78B0")]
		public void Play(Vector3 BAONBICGOEJ, Quaternion CKFJFCLIANA, bool IKIPPDPENJC = false, float NAEDHGDMMLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7A40", Offset = "0x5ED6E40", VA = "0x185ED7A40")]
		public void Play(bool IKIPPDPENJC = false, float NAEDHGDMMLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED87A0", Offset = "0x5ED7BA0", VA = "0x185ED87A0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8710", Offset = "0x5ED7B10", VA = "0x185ED8710")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5ED60B0", Offset = "0x5ED54B0", VA = "0x185ED60B0")]
		private void GHEGFIFJPLA(float DGGLMJANNMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6460", Offset = "0x5ED5860", VA = "0x185ED6460")]
		private void HPKNFDNPPAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7DF0", Offset = "0x5ED71F0", VA = "0x185ED7DF0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8060", Offset = "0x5ED7460", VA = "0x185ED8060")]
		public void SetColor(Color KKBAHNFNJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7370", Offset = "0x5ED6770", VA = "0x185ED7370")]
		private void PBMHHJJGEGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8E10", Offset = "0x5ED8210", VA = "0x185ED8E10")]
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
