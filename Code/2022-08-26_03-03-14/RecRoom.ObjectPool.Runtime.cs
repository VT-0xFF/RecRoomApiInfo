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
		[Cpp2IlInjected.Address(RVA = "0x5835E90", Offset = "0x5834A90", VA = "0x185835E90")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles PAMDOGALOKE, float GBGCKBBNJFF, Vector3 JACLPJHPOFC, Quaternion AHDCMPCBKHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5835C00", Offset = "0x5834800", VA = "0x185835C00")]
		public void SetDamageValue(float GBGCKBBNJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5836030", Offset = "0x5834C30", VA = "0x185836030")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MBKHMOBFMFJ<T> : global::FCECEOPAAFH<T>, OCBCLOGKDMK, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JJODHOMHJAI<T> : OCBCLOGKDMK, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KDNBGCFLOOD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HNAEPLIKKJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GGBIFAIFIGL<T> : global::DHNNFIFBMBD<T>, global::MBKHMOBFMFJ<T>, global::FCECEOPAAFH<T>, OCBCLOGKDMK, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DJEHDPHNMGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public GGBIFAIFIGL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
			public DJEHDPHNMGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2CA0120", Offset = "0x2C9ED20", VA = "0x182CA0120")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2CA0210", Offset = "0x2C9EE10", VA = "0x182CA0210")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::EBGIJCEGKOP<T> LNJEDEBDJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool MKBEOGLCAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T EJKNEJBEEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool JMNCCKFMNPP;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2CA32B0", Offset = "0x2CA1EB0", VA = "0x182CA32B0")]
		public GGBIFAIFIGL(global::EBGIJCEGKOP<T> LNJEDEBDJEJ, ObjectPool MKBEOGLCAJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3170", Offset = "0x2CA1D70", VA = "0x182CA3170", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class BCEJAHBAGHA<T> : HDIMBBGGJPD, global::JJODHOMHJAI<T>, OCBCLOGKDMK, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class LCDEGPGMOCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public BCEJAHBAGHA<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
			public LCDEGPGMOCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2CB0050", Offset = "0x2CAEC50", VA = "0x182CB0050")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1A4F710", Offset = "0x1A4E310", VA = "0x181A4F710")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::EBGIJCEGKOP<T> LNJEDEBDJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool JMNCCKFMNPP;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2C9CE60", Offset = "0x2C9BA60", VA = "0x182C9CE60")]
		public BCEJAHBAGHA(global::EBGIJCEGKOP<T> LNJEDEBDJEJ, ObjectPool MKBEOGLCAJF, int NKMLEGCBFNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2C9CE10", Offset = "0x2C9BA10", VA = "0x182C9CE10", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EBNCPNNEIIJ<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HNAEPLIKKJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::DHNNFIFBMBD<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::EBGIJCEGKOP<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public EBNCPNNEIIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2720", Offset = "0x2CA1320", VA = "0x182CA2720")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA27C0", Offset = "0x2CA13C0", VA = "0x182CA27C0")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2820", Offset = "0x2CA1420", VA = "0x182CA2820")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<KDNBGCFLOOD> NPCCMFNHEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private ELKBOOAGCPG FHNCJIJPKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool MKBEOGLCAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool JMNCCKFMNPP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool KGJMOCHEOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5834BD0", Offset = "0x58337D0", VA = "0x185834BD0")]
	private static void NJBBMCICGHP(Component DGHFPMGLNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5834E30", Offset = "0x5833A30", VA = "0x185834E30")]
	public HNAEPLIKKJM(string POFMMPFMHDI, int BNNJJMDGBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x20CE0F0", Offset = "0x20CCCF0", VA = "0x1820CE0F0")]
	public global::MBKHMOBFMFJ<T> PGAPCMDIPNA<T>(AssetReference AAEMEIBHJGG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x20CE180", Offset = "0x20CCD80", VA = "0x1820CE180")]
	public global::JJODHOMHJAI<T> PGGGMMLIPJJ<T>(AssetReference AAEMEIBHJGG, int BKKGFAKFDNB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1FF69C0", Offset = "0x1FF55C0", VA = "0x181FF69C0")]
	public global::FCECEOPAAFH<bool> CAACINLFJOH<T>(AssetReference AAEMEIBHJGG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5834970", Offset = "0x5833570", VA = "0x185834970", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5834840", Offset = "0x5833440", VA = "0x185834840")]
	private void ANBFFOHOGKO(UnityEngine.Object DHPHBAFGKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5834A80", Offset = "0x5833680", VA = "0x185834A80")]
	private ObjectPool GNFHMPMLFIF(string POFMMPFMHDI)
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
		private static GlobalPool OBPEBAMLBIB;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject KKEPIBLNDKE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool DBFNMCLAAPC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x58346B0", Offset = "0x58332B0", VA = "0x1858346B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5834560", Offset = "0x5833160", VA = "0x185834560")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5834640", Offset = "0x5833240", VA = "0x185834640")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, PIILJEBEDGG> PJGDAMDMOKL;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x202B510", Offset = "0x202A110", VA = "0x18202B510")]
		public T Acquire<T>(T PAMDOGALOKE, [Optional] Action<Component> IGJEMOMHCDO) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B760", Offset = "0x2C9A360", VA = "0x182C9B760")]
		public bool Release<T>(T EBMPLNBFAKM) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x22F4D20", Offset = "0x22F3920", VA = "0x1822F4D20")]
		public void Prefill<T>(T PAMDOGALOKE, int MDOJGKCBAPF, [Optional] Action<Component> JMBLOHNFNDB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B6C0", Offset = "0x2C9A2C0", VA = "0x182C9B6C0")]
		public bool Exists<T>(T PAMDOGALOKE) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x22F4C80", Offset = "0x22F3880", VA = "0x1822F4C80")]
		public void Clear<T>(T PAMDOGALOKE) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x58354B0", Offset = "0x58340B0", VA = "0x1858354B0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3138060", Offset = "0x3136C60", VA = "0x183138060")]
		private PIILJEBEDGG IEOBEGHFABJ<T>(T PAMDOGALOKE) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		public void TrackInstantiation(string PODGBPAOOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		public void EnableStats(bool ACAPJNIAFIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5834640", Offset = "0x5833240", VA = "0x185834640")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class PIILJEBEDGG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface DEMPDMOOPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JNDHDIOACAF(bool MPECIKDKPDM);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component DDFMCGOBKNB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string DNLLPFFBEAL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int LJECHHDHECA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void PGGGMMLIPJJ(int BKKGFAKFDNB, Action<Component> JMBLOHNFNDB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component PGAPCMDIPNA(Action<Component> IGJEMOMHCDO);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool EMMKKOCKPGD(Component NLHJOACNOCK);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void LONCNHKPMCG();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x58357E0", Offset = "0x58343E0", VA = "0x1858357E0")]
	protected void JAPNCHLJHKN(Component EBMPLNBFAKM, bool MPECIKDKPDM, bool IHACIGAJIME, bool CNLLBCCHEHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58341F0", VA = "0x1858355F0")]
	protected void HINDJJAMFAC(Transform PKJPFCNKKCA, bool MPECIKDKPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	protected PIILJEBEDGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PCMJINKHNCC<T> : PIILJEBEDGG where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T PAMDOGALOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool IACOODGNPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool IHACIGAJIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> CABOEKMHKKB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component DDFMCGOBKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string DNLLPFFBEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3A1A850", Offset = "0x3A19450", VA = "0x183A1A850", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int LJECHHDHECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3A1A540", Offset = "0x3A19140", VA = "0x183A1A540", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3A1ADF0", Offset = "0x3A199F0", VA = "0x183A1ADF0")]
	public PCMJINKHNCC(T PAMDOGALOKE, ObjectPool IACOODGNPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3A1ACE0", Offset = "0x3A198E0", VA = "0x183A1ACE0", Slot = "7")]
	public override void PGGGMMLIPJJ(int BKKGFAKFDNB, Action<Component> IGJEMOMHCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3A1AAB0", Offset = "0x3A196B0", VA = "0x183A1AAB0", Slot = "8")]
	public override Component PGAPCMDIPNA(Action<Component> IGJEMOMHCDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A570", Offset = "0x3A19170", VA = "0x183A1A570", Slot = "9")]
	public override bool EMMKKOCKPGD(Component NLHJOACNOCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A870", Offset = "0x3A19470", VA = "0x183A1A870", Slot = "10")]
	public override void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A700", Offset = "0x3A19300", VA = "0x183A1A700")]
	private T IFFHNLHGCDN()
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
		public interface MPFPNIFDMGD
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject BHGGBLDCKHL
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5835160", Offset = "0x5833D60", VA = "0x185835160")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5835440", Offset = "0x5834040", VA = "0x185835440")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool OBPEBAMLBIB;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject KKEPIBLNDKE;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool DBFNMCLAAPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5835A40", Offset = "0x5834640", VA = "0x185835A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5835960", Offset = "0x5834560", VA = "0x185835960")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5834640", Offset = "0x5833240", VA = "0x185834640")]
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
		public PIILJEBEDGG PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public PooledObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private enum OGAGDADFDLL
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public interface PALICNEEIKE
		{
			[Cpp2IlInjected.Token(Token = "0x17000010")]
			bool GOABLJGDAOE
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			Vector3 DHHKMMNFKPF
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Camera DMAFNDENOBK
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA7AC00", Offset = "0xA79800", VA = "0x180A7AC00")]
			public ColorConfiguration(ParticleSystem DBBEGEMHNMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5833300", Offset = "0x5831F00", VA = "0x185833300")]
			public void DDGLDMMPCJM(Color OKGJEMGBDBL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class GHKDBODGLJM : IEnumerator<OGCDMMFGIGL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private OGCDMMFGIGL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private PALICNEEIKE <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private OGCDMMFGIGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6FD7D0", Offset = "0x6FC3D0", VA = "0x1806FD7D0")]
			[DebuggerHidden]
			public GHKDBODGLJM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5833B00", Offset = "0x5832700", VA = "0x185833B00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5834510", Offset = "0x5833110", VA = "0x185834510", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class IEIMBPDDHOJ : IEnumerator<OGCDMMFGIGL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private OGCDMMFGIGL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private OGCDMMFGIGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6FD7D0", Offset = "0x6FC3D0", VA = "0x1806FD7D0")]
			[DebuggerHidden]
			public IEIMBPDDHOJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5835050", Offset = "0x5833C50", VA = "0x185835050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5835110", Offset = "0x5833D10", VA = "0x185835110", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> BAJDDGEPOEE;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static List<PooledParticle> BHFJJDBNLLG;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static GECAAOLGCPI EFGAJJMGDNJ;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const float POGBMFGBFFH = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static bool ALHGFNIOIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		protected int PIEBEFLIHNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private ParticleSystem.MinMaxGradient[] AJBAEABCKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool CDHNOCLJNIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float LDLNGFDDPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float GIGFAAOCCPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Transform IANOMGCODLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Vector3 NALDEKJINGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private Vector3 EJKNLIKLBFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private OGAGDADFDLL AEMLBLGIBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private GECAAOLGCPI IBLAAJEFGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected bool MLOAKHANDDE;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected static bool HGCKKAIBEPB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5836DC0", Offset = "0x58359C0", VA = "0x185836DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ParticleSystem EGMFFDBDBKP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x710440", Offset = "0x70F040", VA = "0x180710440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ParticleSystem[] FGPMCHGAEIO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x614A30", Offset = "0x613630", VA = "0x180614A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x724880", Offset = "0x723480", VA = "0x180724880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private ParticleSystemRenderer[] LGKNPNELBOB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5ED010", Offset = "0x5EBC10", VA = "0x1805ED010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5ED020", Offset = "0x5EBC20", VA = "0x1805ED020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private OGAGDADFDLL HOIAJLAMHAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6B7380", Offset = "0x6B5F80", VA = "0x1806B7380")]
			get
			{
				return default(OGAGDADFDLL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5836DA0", Offset = "0x58359A0", VA = "0x185836DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FDEKBLHONNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5838CF0", Offset = "0x58378F0", VA = "0x185838CF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5838D90", Offset = "0x5837990", VA = "0x185838D90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5838990", Offset = "0x5837590", VA = "0x185838990")]
		public static PooledParticle TryPlayPrefab(PooledParticle PAMDOGALOKE, Vector3 JACLPJHPOFC, Quaternion AHDCMPCBKHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x58387A0", Offset = "0x58373A0", VA = "0x1858387A0")]
		public static PooledParticle TryPlayPrefab(PooledParticle PAMDOGALOKE, Vector3 JACLPJHPOFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5837FE0", Offset = "0x5836BE0", VA = "0x185837FE0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5836840", Offset = "0x5835440", VA = "0x185836840")]
		private void GJEHJOGDBJK(bool INBOJIDPLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x58364A0", Offset = "0x58350A0", VA = "0x1858364A0")]
		[IteratorStateMachine(typeof(GHKDBODGLJM))]
		private static IEnumerator<OGCDMMFGIGL> CBHCAAEEBFB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5836940", Offset = "0x5835540", VA = "0x185836940")]
		protected void IMJOBLFEJJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5836E70", Offset = "0x5835A70", VA = "0x185836E70")]
		protected void ONOHDCJMDDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x58362B0", Offset = "0x5834EB0", VA = "0x1858362B0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5836AC0", Offset = "0x58356C0", VA = "0x185836AC0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5837320", Offset = "0x5835F20", VA = "0x185837320")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x58368C0", Offset = "0x58354C0", VA = "0x1858368C0")]
		[IteratorStateMachine(typeof(IEIMBPDDHOJ))]
		private IEnumerator<OGCDMMFGIGL> IJLJOAFHGND(float NGEGFNDGCFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5836520", Offset = "0x5835120", VA = "0x185836520")]
		private void EMMKKOCKPGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5838580", Offset = "0x5837180", VA = "0x185838580")]
		public void SetDuration(float NGEGFNDGCFI, bool FIHLIJLAOAH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5837D40", Offset = "0x5836940", VA = "0x185837D40")]
		public void Play(Transform JHJPHBNOCMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5837BB0", Offset = "0x58367B0", VA = "0x185837BB0")]
		public void Play(Transform JHJPHBNOCMP, bool EPJELKMJDAO, float PHCACENBOKB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5837820", Offset = "0x5836420", VA = "0x185837820")]
		public void Play(Transform JHJPHBNOCMP, Vector3 EJKNLIKLBFD, bool EPJELKMJDAO, float PHCACENBOKB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x58375D0", Offset = "0x58361D0", VA = "0x1858375D0")]
		public void Play(Transform HOGBMJNOGEL, Quaternion AHDCMPCBKHJ, bool EPJELKMJDAO = false, float PHCACENBOKB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5837970", Offset = "0x5836570", VA = "0x185837970")]
		public void Play(Transform HOGBMJNOGEL, Vector3 EJKNLIKLBFD, Quaternion AHDCMPCBKHJ, bool EPJELKMJDAO = false, float PHCACENBOKB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5837750", Offset = "0x5836350", VA = "0x185837750")]
		public void Play(Vector3 JACLPJHPOFC, Quaternion AHDCMPCBKHJ, Vector3 HOMFEOIMGHK, bool EPJELKMJDAO = false, float PHCACENBOKB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5837510", Offset = "0x5836110", VA = "0x185837510")]
		public void Play(Vector3 JACLPJHPOFC, Quaternion AHDCMPCBKHJ, bool EPJELKMJDAO = false, float PHCACENBOKB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5837AA0", Offset = "0x58366A0", VA = "0x185837AA0")]
		public void Play(bool EPJELKMJDAO = false, float PHCACENBOKB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5838710", Offset = "0x5837310", VA = "0x185838710")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5838660", Offset = "0x5837260", VA = "0x185838660")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x58366C0", Offset = "0x58352C0", VA = "0x1858366C0")]
		private void GCEAGCJOEID(float NGEGFNDGCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x58373A0", Offset = "0x5835FA0", VA = "0x1858373A0")]
		private void PPJLEPFLMGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5837EC0", Offset = "0x5836AC0", VA = "0x185837EC0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5838160", Offset = "0x5836D60", VA = "0x185838160")]
		public void SetColor(Color OKGJEMGBDBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5836110", Offset = "0x5834D10", VA = "0x185836110")]
		private void ACKFPEIJCIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5838C60", Offset = "0x5837860", VA = "0x185838C60")]
		public PooledParticle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x58364F0", Offset = "0x58350F0", VA = "0x1858364F0")]
		[CompilerGenerated]
		private void DFJKIJDOIEK(ParticleSystemRenderer DMHIDIPAPKL)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GGMACBOFMDA
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static byte[] HNILJCLIGCF;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static int MHDNNHPLAAF;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static int JKLLCIMILJG;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static BigInteger JLHIBEKHFGK;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GGMACBOFMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5833840", Offset = "0x5832440", VA = "0x185833840")]
	private static string PBMOEILNFIF(byte[] EDLPJGEPJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5833510", Offset = "0x5832110", VA = "0x185833510")]
	public static string EICDLCDOCAE(byte[] IAIFCDOPKGE, bool LFDDCGMHEMH)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
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
