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
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		[Header("Impact Particle Start Size")]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72BB200", Offset = "0x72BA600", VA = "0x1872BB200")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles FIDMHGJFAFJ, float JBJFCMEGLLM, Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72BAEA0", Offset = "0x72BA2A0", VA = "0x1872BAEA0")]
		public void SetDamageValue(float JBJFCMEGLLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72BB3D0", Offset = "0x72BA7D0", VA = "0x1872BB3D0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ILDBHJPJMPG<T> : AMMGOODCICE<T>, CLHPIMOBJFN, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ANNKDLKOEAH<T> : CLHPIMOBJFN, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GDCIAEBOFPN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HGFHMCLCJJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NPEEPPIAOKA<T> : ECGKMFIAIBN<T>, ILDBHJPJMPG<T>, AMMGOODCICE<T>, CLHPIMOBJFN, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ABPLLIKNHLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public NPEEPPIAOKA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public ABPLLIKNHLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4138ED0", Offset = "0x41382D0", VA = "0x184138ED0")]
			internal void ILHGHBJFLPC(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2F66840", Offset = "0x2F65C40", VA = "0x182F66840")]
			internal void KGHKCIMPLKK(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PLBFKJMGACI<T> PMEENBNGGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool IBKICPIINOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T JHHLONNMNDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool IOFECLNHDIM;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4A9E9B0", Offset = "0x4A9DDB0", VA = "0x184A9E9B0")]
		public NPEEPPIAOKA(PLBFKJMGACI<T> PMEENBNGGPA, ObjectPool IBKICPIINOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4A9E840", Offset = "0x4A9DC40", VA = "0x184A9E840", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class BCBJKHKHFFC<T> : FPFCPNKOFAP, ANNKDLKOEAH<T>, CLHPIMOBJFN, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class GKFEDCBMJHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public BCBJKHKHFFC<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public GKFEDCBMJHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x419F700", Offset = "0x419EB00", VA = "0x18419F700")]
			internal void ILHGHBJFLPC(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xF78FA0", Offset = "0xF783A0", VA = "0x180F78FA0")]
			internal void KGHKCIMPLKK(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private PLBFKJMGACI<T> PMEENBNGGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool IOFECLNHDIM;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x53AF650", Offset = "0x53AEA50", VA = "0x1853AF650")]
		public BCBJKHKHFFC(PLBFKJMGACI<T> PMEENBNGGPA, ObjectPool IBKICPIINOD, int JDBENNHIBLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x53AF5F0", Offset = "0x53AE9F0", VA = "0x1853AF5F0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FGFFKDCDMJL<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HGFHMCLCJJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ECGKMFIAIBN<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public PLBFKJMGACI<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FGFFKDCDMJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x407E4D0", Offset = "0x407D8D0", VA = "0x18407E4D0")]
		internal void OKCHAMBHNEE(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x407E420", Offset = "0x407D820", VA = "0x18407E420")]
		internal void DKOJAIOEFCO(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x407E480", Offset = "0x407D880", VA = "0x18407E480")]
		internal void JPIGMPPHELG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<GDCIAEBOFPN> PNDBNLMPCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private FJGNNDDPALA OEMMGHPLCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool IBKICPIINOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool IOFECLNHDIM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72B9DC0", Offset = "0x72B91C0", VA = "0x1872B9DC0")]
	private static void ECCKLBEANPA(Component HFEBDCHJGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72BA360", Offset = "0x72B9760", VA = "0x1872BA360")]
	public HGFHMCLCJJN(string BLNFCPHILBB, int BJNLDKIHIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3078C70", Offset = "0x3078070", VA = "0x183078C70")]
	public ILDBHJPJMPG<T> ECCEODIIMHH<T>(AssetReference CBFFHFKIBPI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3078D40", Offset = "0x3078140", VA = "0x183078D40")]
	public ANNKDLKOEAH<T> FKGMGHIJDFM<T>(AssetReference CBFFHFKIBPI, int ABPDJOGPHFP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3078870", Offset = "0x3077C70", VA = "0x183078870")]
	public AMMGOODCICE<bool> BEGHCPGHHPC<T>(AssetReference CBFFHFKIBPI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72B9CD0", Offset = "0x72B90D0", VA = "0x1872B9CD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72BA000", Offset = "0x72B9400", VA = "0x1872BA000")]
	private void LCKDCAKAKBI(UnityEngine.Object ABONMOMEKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72BA140", Offset = "0x72B9540", VA = "0x1872BA140")]
	private ObjectPool OEHICIPNPFN(string BLNFCPHILBB)
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
		private static GlobalPool BHKNECAGMPF;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject KNOGHAIAFFO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool ELEBKANKHDF
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x72B9B80", Offset = "0x72B8F80", VA = "0x1872B9B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3073D40", Offset = "0x3073140", VA = "0x183073D40")]
		public static void SafeRelease<T>(T NCHBKHMIMGJ) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72B9AB0", Offset = "0x72B8EB0", VA = "0x1872B9AB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72B9B70", Offset = "0x72B8F70", VA = "0x1872B9B70")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, CNEOBNJANKL> LKCJNDGJBAO;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x321E5A0", Offset = "0x321D9A0", VA = "0x18321E5A0")]
		public T Acquire<T>(T FIDMHGJFAFJ, [Optional] Action<Component> EMEKHIDIOPE) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x321E960", Offset = "0x321DD60", VA = "0x18321E960")]
		public bool Release<T>(T NCHBKHMIMGJ) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x321E8F0", Offset = "0x321DCF0", VA = "0x18321E8F0")]
		public void Prefill<T>(T FIDMHGJFAFJ, int EMLGGFAKKCH, [Optional] Action<Component> GMLFDEHEJAH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x321E710", Offset = "0x321DB10", VA = "0x18321E710")]
		public bool Exists<T>(T FIDMHGJFAFJ) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x321E660", Offset = "0x321DA60", VA = "0x18321E660")]
		public void Clear<T>(T FIDMHGJFAFJ) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x72BAA60", Offset = "0x72B9E60", VA = "0x1872BAA60")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x321E7B0", Offset = "0x321DBB0", VA = "0x18321E7B0")]
		private CNEOBNJANKL LKEPIFEGJHJ<T>(T FIDMHGJFAFJ) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
		public void TrackInstantiation(string CNPIIHJJJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
		public void EnableStats(bool JNLMEFKIJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x72BABD0", Offset = "0x72B9FD0", VA = "0x1872BABD0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class CNEOBNJANKL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NPKOCDPNCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BLPEECKBONE(bool PBDMKBICHHC);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string DKCJKHANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int OMHMFJLBCGE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void FKGMGHIJDFM(int ABPDJOGPHFP, Action<Component> GMLFDEHEJAH);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component ECCEODIIMHH(Action<Component> EMEKHIDIOPE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool OLENLPMJDLF(Component KJJAJBPPHOF);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void CDMKLDGEKPL();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72B8E60", Offset = "0x72B8260", VA = "0x1872B8E60")]
	protected void IGBLNCFIBJB(Component NCHBKHMIMGJ, bool PBDMKBICHHC, bool PENFBHGEIMC, bool CLONIDODHBB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x72B8FE0", Offset = "0x72B83E0", VA = "0x1872B8FE0")]
	protected void PFOEKPEJAIJ(Transform DEDGJIAKOOG, bool PBDMKBICHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	protected CNEOBNJANKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FFDOMFDDLAM<T> : CNEOBNJANKL where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T FIDMHGJFAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool CDJMGDBPKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool PENFBHGEIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> COFLAGENLCF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string DKCJKHANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4071B90", Offset = "0x4070F90", VA = "0x184071B90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int OMHMFJLBCGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4071D30", Offset = "0x4071130", VA = "0x184071D30", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4071F50", Offset = "0x4071350", VA = "0x184071F50")]
	public FFDOMFDDLAM(T FIDMHGJFAFJ, ObjectPool CDJMGDBPKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4071A60", Offset = "0x4070E60", VA = "0x184071A60", Slot = "6")]
	public override void FKGMGHIJDFM(int ABPDJOGPHFP, Action<Component> EMEKHIDIOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x40717D0", Offset = "0x4070BD0", VA = "0x1840717D0", Slot = "7")]
	public override Component ECCEODIIMHH(Action<Component> EMEKHIDIOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4071D90", Offset = "0x4071190", VA = "0x184071D90", Slot = "8")]
	public override bool OLENLPMJDLF(Component KJJAJBPPHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x40715B0", Offset = "0x40709B0", VA = "0x1840715B0", Slot = "9")]
	public override void CDMKLDGEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4071BB0", Offset = "0x4070FB0", VA = "0x184071BB0")]
	private T NNJKNACHKDK()
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
		public interface ABGMLBKGGKO
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject CPLLCBOIHJA
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
		[Cpp2IlInjected.Address(RVA = "0x72BA6E0", Offset = "0x72B9AE0", VA = "0x1872BA6E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x72BA9D0", Offset = "0x72B9DD0", VA = "0x1872BA9D0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool BHKNECAGMPF;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject KNOGHAIAFFO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool ELEBKANKHDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x72BAD20", Offset = "0x72BA120", VA = "0x1872BAD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x72BAC60", Offset = "0x72BA060", VA = "0x1872BAC60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72B9B70", Offset = "0x72B8F70", VA = "0x1872B9B70")]
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
		public CNEOBNJANKL PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PJLDIPLPCEE
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int DIEGBKMIFPH(PooledParticle.IKKDNMKLDAE KAEMFOIOGCN);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum BLHPCOMOAFM
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum IKKDNMKLDAE
		{
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface MCGBMAAGJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool OFMBNEHKNGH
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 CIMPHENEDJE
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera LPKOKANOIHM
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
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6133D00", Offset = "0x6133100", VA = "0x186133D00")]
			public ColorConfiguration(ParticleSystem HNKJFKHFIFI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x72B9260", Offset = "0x72B8660", VA = "0x1872B9260")]
			public void CANPFNGNKKF(Color IGJDLCJEHCH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class JBJPDNKOJIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public JBJPDNKOJIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x72BA5F0", Offset = "0x72B99F0", VA = "0x1872BA5F0")]
			internal void DLMAMPGENIA(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class EPADFEODFBG : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private ONHNFKGBFKG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private MCGBMAAGJPJ <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
			[DebuggerHidden]
			public EPADFEODFBG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x72B9450", Offset = "0x72B8850", VA = "0x1872B9450", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x72B9A60", Offset = "0x72B8E60", VA = "0x1872B9A60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class LBBNPGMJBFJ : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private ONHNFKGBFKG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
			[DebuggerHidden]
			public LBBNPGMJBFJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x72BA620", Offset = "0x72B9A20", VA = "0x1872BA620", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x72BA690", Offset = "0x72B9A90", VA = "0x1872BA690", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> GCCFEENKFKG;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<PJLDIPLPCEE> DCLHEMBOELH;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> CHGACCGIHOK;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static GLHJGEGNDCM DAOCJDKLKLP;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float ICHKHBAKAKB = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool JEDECPBENGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int DGPKILMOGAI;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private IKKDNMKLDAE category;

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
		private ParticleSystem.MinMaxGradient[] PHIOBCEDKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool EAGENGOLLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float CNODOIJKOEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float GDLKEGCIBHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform CABJKLKLINI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 OEAHOEPJGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 GKAINJEFLAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private BLHPCOMOAFM JPELJIHPIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private GLHJGEGNDCM BFCHKLOMPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool LDDBAEENJAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Transform NOBMIEKHLON;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> KFJJGINFNHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x72BEE60", Offset = "0x72BE260", VA = "0x1872BEE60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IKKDNMKLDAE MCIGCACBHJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8EF030", Offset = "0x8EE430", VA = "0x1808EF030")]
			get
			{
				return default(IKKDNMKLDAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int LHMPACFKMKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8C93C0", Offset = "0x8C87C0", VA = "0x1808C93C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NPJNGPAAGID
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x72BEBB0", Offset = "0x72BDFB0", VA = "0x1872BEBB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int PFAPONCFAOH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x72BED20", Offset = "0x72BE120", VA = "0x1872BED20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool CEOMGGCDIKE
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x72BBC10", Offset = "0x72BB010", VA = "0x1872BBC10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem DOOJLNFBFGP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DD0", Offset = "0x8C71D0", VA = "0x1808C7DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] FCFALGLACPM
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8C8C80", Offset = "0x8C8080", VA = "0x1808C8C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] FJMIGGFPGOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8C7970", Offset = "0x8C6D70", VA = "0x1808C7970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8D0CD0", Offset = "0x8D00D0", VA = "0x1808D0CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private BLHPCOMOAFM EMAMBKFIHJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x13F9F00", Offset = "0x13F9300", VA = "0x1813F9F00")]
			get
			{
				return default(BLHPCOMOAFM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x72BC2E0", Offset = "0x72BB6E0", VA = "0x1872BC2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform KELFOJAPBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x72BEEB0", Offset = "0x72BE2B0", VA = "0x1872BEEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action DJAMEAANGAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x72BEB10", Offset = "0x72BDF10", VA = "0x1872BEB10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x72BEF00", Offset = "0x72BE300", VA = "0x1872BEF00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x72BE450", Offset = "0x72BD850", VA = "0x1872BE450")]
		public static PooledParticle TryPlayPrefab(PooledParticle FIDMHGJFAFJ, Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x72BE600", Offset = "0x72BDA00", VA = "0x1872BE600")]
		public static PooledParticle TryPlayPrefab(PooledParticle FIDMHGJFAFJ, Vector3 CPGMOBFHDAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x72BDB10", Offset = "0x72BCF10", VA = "0x1872BDB10")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x72BB6C0", Offset = "0x72BAAC0", VA = "0x1872BB6C0")]
		private void BDFBDGHGAIH(bool GLCFJLGEAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x72BBC90", Offset = "0x72BB090", VA = "0x1872BBC90")]
		[IteratorStateMachine(typeof(EPADFEODFBG))]
		private static IEnumerator<ONHNFKGBFKG> GFAAKFPIGLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x72BC300", Offset = "0x72BB700", VA = "0x1872BC300")]
		private static void KOPDNOKHPKP(Stopwatch HIKLLEDALJM, Vector3 GJMAAIKPBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x72BBA60", Offset = "0x72BAE60", VA = "0x1872BBA60")]
		private static int CLMFDAJMBMK(PooledParticle FGFJFGGJOII, PooledParticle CABLGFIBABJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x72BBB10", Offset = "0x72BAF10", VA = "0x1872BBB10")]
		private static int DIEGBKMIFPH(IKKDNMKLDAE KAEMFOIOGCN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x72BC950", Offset = "0x72BBD50", VA = "0x1872BC950")]
		protected void MPONCDPFDDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x72BBCF0", Offset = "0x72BB0F0", VA = "0x1872BBCF0")]
		protected void HAODFNCJCLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x72BB4A0", Offset = "0x72BA8A0", VA = "0x1872BB4A0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x72BC670", Offset = "0x72BBA70", VA = "0x1872BC670")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x72BCE60", Offset = "0x72BC260", VA = "0x1872BCE60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x72BCC70", Offset = "0x72BC070", VA = "0x1872BCC70")]
		[IteratorStateMachine(typeof(LBBNPGMJBFJ))]
		private IEnumerator<ONHNFKGBFKG> OHICOMPCKCE(float BOHBFCKDKCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x72BCD00", Offset = "0x72BC100", VA = "0x1872BCD00")]
		private void OLENLPMJDLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x72BE260", Offset = "0x72BD660", VA = "0x1872BE260")]
		public void SetDuration(float BOHBFCKDKCE, bool HDOBAGMGDJK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x72BCEE0", Offset = "0x72BC2E0", VA = "0x1872BCEE0")]
		public void Play(Transform NGIHILDJGDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72BD6E0", Offset = "0x72BCAE0", VA = "0x1872BD6E0")]
		public void Play(Transform NGIHILDJGDO, bool HJILJAOIHGJ, float HPAFBENCMNH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x72BD080", Offset = "0x72BC480", VA = "0x1872BD080")]
		public void Play(Transform NGIHILDJGDO, Vector3 GKAINJEFLAA, bool HJILJAOIHGJ, float HPAFBENCMNH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72BD210", Offset = "0x72BC610", VA = "0x1872BD210")]
		public void Play(Transform KFNKKALEANI, Quaternion CBCAIPELAJP, bool HJILJAOIHGJ = false, float HPAFBENCMNH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x72BD8A0", Offset = "0x72BCCA0", VA = "0x1872BD8A0")]
		public void Play(Transform KFNKKALEANI, Vector3 GKAINJEFLAA, Quaternion CBCAIPELAJP, bool HJILJAOIHGJ = false, float HPAFBENCMNH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x72BD4B0", Offset = "0x72BC8B0", VA = "0x1872BD4B0")]
		public void Play(Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, Vector3 KLNNEIDEPKF, bool HJILJAOIHGJ = false, float HPAFBENCMNH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x72BD3B0", Offset = "0x72BC7B0", VA = "0x1872BD3B0")]
		public void Play(Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, bool HJILJAOIHGJ = false, float HPAFBENCMNH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x72BD5D0", Offset = "0x72BC9D0", VA = "0x1872BD5D0")]
		public void Play(bool HJILJAOIHGJ = false, float HPAFBENCMNH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x72BE3C0", Offset = "0x72BD7C0", VA = "0x1872BE3C0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x72BE330", Offset = "0x72BD730", VA = "0x1872BE330")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x72BB8D0", Offset = "0x72BACD0", VA = "0x1872BB8D0")]
		private void CFLJBBFHMHG(float BOHBFCKDKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x72BB790", Offset = "0x72BAB90", VA = "0x1872BB790")]
		private void BHFKKDFJBHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x72BDA20", Offset = "0x72BCE20", VA = "0x1872BDA20")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x72BDC90", Offset = "0x72BD090", VA = "0x1872BDC90")]
		public void SetColor(Color IGJDLCJEHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x72BCB40", Offset = "0x72BBF40", VA = "0x1872BCB40")]
		private void NEECABADLDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x72BEA80", Offset = "0x72BDE80", VA = "0x1872BEA80")]
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
