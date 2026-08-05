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
		[Cpp2IlInjected.Address(RVA = "0x27E3550", Offset = "0x27E2750", VA = "0x1827E3550")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles DBHBBNPKELE, float LGIGDCDECLF, Vector3 BCCJFEBGGPE, Quaternion PAOOIKIKMBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27E32C0", Offset = "0x27E24C0", VA = "0x1827E32C0")]
		public void SetDamageValue(float LGIGDCDECLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x27E36F0", Offset = "0x27E28F0", VA = "0x1827E36F0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KCBPMHFOKGL<T> : global::GDKGOJJDLGI<T>, NOJPGNEJCEO, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EOJNGJHMDGK<T> : NOJPGNEJCEO, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FCMGKBMNAPD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HHODOIMPEJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class AEIJOBDNDMN<T> : global::OKHIKHGPKEJ<T>, global::KCBPMHFOKGL<T>, global::GDKGOJJDLGI<T>, NOJPGNEJCEO, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class NOPIBCFDEDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public AEIJOBDNDMN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
			public NOPIBCFDEDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x39FE250", Offset = "0x39FD450", VA = "0x1839FE250")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1E06410", Offset = "0x1E05610", VA = "0x181E06410")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::PLAJGGCOHJE<T> CDDLIMHNLKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool GNDNCDKHCOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T BGGBBPALEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool JGKFDLIIMNF;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x39E7600", Offset = "0x39E6800", VA = "0x1839E7600")]
		public AEIJOBDNDMN(global::PLAJGGCOHJE<T> CDDLIMHNLKM, ObjectPool GNDNCDKHCOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x39E74C0", Offset = "0x39E66C0", VA = "0x1839E74C0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class KGJPFECNENP<T> : GGMBIJOCENK, global::EOJNGJHMDGK<T>, NOJPGNEJCEO, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class JDFHDGIEDHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public KGJPFECNENP<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
			public JDFHDGIEDHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x39FDE60", Offset = "0x39FD060", VA = "0x1839FDE60")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x3565B90", Offset = "0x3564D90", VA = "0x183565B90")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::PLAJGGCOHJE<T> CDDLIMHNLKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool JGKFDLIIMNF;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x39FDF70", Offset = "0x39FD170", VA = "0x1839FDF70")]
		public KGJPFECNENP(global::PLAJGGCOHJE<T> CDDLIMHNLKM, ObjectPool GNDNCDKHCOJ, int CGLIKININPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x39FDF20", Offset = "0x39FD120", VA = "0x1839FDF20", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GGAIJKJOIEC<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HHODOIMPEJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::OKHIKHGPKEJ<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::PLAJGGCOHJE<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public GGAIJKJOIEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x39E89F0", Offset = "0x39E7BF0", VA = "0x1839E89F0")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x39E8A90", Offset = "0x39E7C90", VA = "0x1839E8A90")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x39E8AF0", Offset = "0x39E7CF0", VA = "0x1839E8AF0")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<FCMGKBMNAPD> COJNHLLCPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private FECPHFEMEMC HNEOPDFEILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool GNDNCDKHCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool JGKFDLIIMNF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool AONFCOKHGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27E1590", Offset = "0x27E0790", VA = "0x1827E1590")]
	private static void ILLJHONDHBH(Component OFADDADJKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27E1920", Offset = "0x27E0B20", VA = "0x1827E1920")]
	public HHODOIMPEJO(string HDMGIBELFDJ, int JNBDABCHPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7020", Offset = "0x3CB6220", VA = "0x183CB7020")]
	public global::KCBPMHFOKGL<T> PNAMDBOJCNA<T>(AssetReference PONMIHGJDPK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x38385F0", Offset = "0x38377F0", VA = "0x1838385F0")]
	public global::EOJNGJHMDGK<T> HDADCAEKCBM<T>(AssetReference PONMIHGJDPK, int AEKEPEKODMN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x38386A0", Offset = "0x38378A0", VA = "0x1838386A0")]
	public global::GDKGOJJDLGI<bool> PNGIIMFCLDE<T>(AssetReference PONMIHGJDPK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27E1480", Offset = "0x27E0680", VA = "0x1827E1480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x27E1790", Offset = "0x27E0990", VA = "0x1827E1790")]
	private void OKBKHMCEOPE(UnityEngine.Object JIIDDCOLBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x27E1330", Offset = "0x27E0530", VA = "0x1827E1330")]
	private ObjectPool DFJMEINODEL(string HDMGIBELFDJ)
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
		private static GlobalPool JKJNOFGBPPO;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject DJHHAHJBEBP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool HBKBBJLFPOI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x27E11A0", Offset = "0x27E03A0", VA = "0x1827E11A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x27E1050", Offset = "0x27E0250", VA = "0x1827E1050")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x27E1130", Offset = "0x27E0330", VA = "0x1827E1130")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, ENIHFBEGIHO> ADNNEBHFPNB;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x38849C0", Offset = "0x3883BC0", VA = "0x1838849C0")]
		public T Acquire<T>(T DBHBBNPKELE, [Optional] Action<Component> GLMKAADKILI) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2EC0", Offset = "0x3AE20C0", VA = "0x183AE2EC0")]
		public bool Release<T>(T PBKPNJLDBOM) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3B2ED80", Offset = "0x3B2DF80", VA = "0x183B2ED80")]
		public void Prefill<T>(T DBHBBNPKELE, int MNOHOBLNLCE, [Optional] Action<Component> HIMLMFDJLPN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2E20", Offset = "0x3AE2020", VA = "0x183AE2E20")]
		public bool Exists<T>(T DBHBBNPKELE) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3B2ECE0", Offset = "0x3B2DEE0", VA = "0x183B2ECE0")]
		public void Clear<T>(T DBHBBNPKELE) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x27E2EE0", Offset = "0x27E20E0", VA = "0x1827E2EE0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x383F490", Offset = "0x383E690", VA = "0x18383F490")]
		private ENIHFBEGIHO HGPKLIEDBKP<T>(T DBHBBNPKELE) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		public void TrackInstantiation(string PMANKAEMFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		public void EnableStats(bool IOGCDBPIHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x27E1130", Offset = "0x27E0330", VA = "0x1827E1130")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class ENIHFBEGIHO
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface CPHNDDHEHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LJDGGPLACLF(bool EAMGOFONHJA);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component EPGKLMKNPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string JPGOKIEGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int LOFOLPLJKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void HDADCAEKCBM(int AEKEPEKODMN, Action<Component> HIMLMFDJLPN);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component PNAMDBOJCNA(Action<Component> GLMKAADKILI);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool PLGIPNAJDEI(Component OHLDDLIMNHB);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void NLALCDJNEAF();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x27E0CE0", Offset = "0x27DFEE0", VA = "0x1827E0CE0")]
	protected void GOLJIFLLDDD(Component PBKPNJLDBOM, bool EAMGOFONHJA, bool DEBDFALNPOB, bool FKCCOPMNLOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x27E0E60", Offset = "0x27E0060", VA = "0x1827E0E60")]
	protected void HHCOHAOCOOP(Transform LHAIAGOMHCL, bool EAMGOFONHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	protected ENIHFBEGIHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PNDGBEIFINI<T> : ENIHFBEGIHO where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T DBHBBNPKELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool APFLDACPIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool DEBDFALNPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> LPNJCECMLKL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component EPGKLMKNPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string JPGOKIEGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x452FCE0", Offset = "0x452EEE0", VA = "0x18452FCE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int LOFOLPLJKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x45301A0", Offset = "0x452F3A0", VA = "0x1845301A0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4530590", Offset = "0x452F790", VA = "0x184530590")]
	public PNDGBEIFINI(T DBHBBNPKELE, ObjectPool APFLDACPIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x452FD00", Offset = "0x452EF00", VA = "0x18452FD00", Slot = "7")]
	public override void HDADCAEKCBM(int AEKEPEKODMN, Action<Component> GLMKAADKILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4530360", Offset = "0x452F560", VA = "0x184530360", Slot = "8")]
	public override Component PNAMDBOJCNA(Action<Component> GLMKAADKILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x45301D0", Offset = "0x452F3D0", VA = "0x1845301D0", Slot = "9")]
	public override bool PLGIPNAJDEI(Component OHLDDLIMNHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x452FE10", Offset = "0x452F010", VA = "0x18452FE10", Slot = "10")]
	public override void NLALCDJNEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4530050", Offset = "0x452F250", VA = "0x184530050")]
	private T OJIBCIHGFFI()
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
		public interface CIALAMPIICA
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject CODPGIGHGNI
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
		[Cpp2IlInjected.Address(RVA = "0x27E2B90", Offset = "0x27E1D90", VA = "0x1827E2B90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x27E2E70", Offset = "0x27E2070", VA = "0x1827E2E70")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool JKJNOFGBPPO;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject DJHHAHJBEBP;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool HBKBBJLFPOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x27E3100", Offset = "0x27E2300", VA = "0x1827E3100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x27E3020", Offset = "0x27E2220", VA = "0x1827E3020")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x27E1130", Offset = "0x27E0330", VA = "0x1827E1130")]
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
		public ENIHFBEGIHO PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public PooledObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private enum IAEFNCAEJAI
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
		public interface CILFCLIHNND
		{
			[Cpp2IlInjected.Token(Token = "0x17000010")]
			bool MKLIGOONJEL
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			Vector3 MJDHBOKAFMN
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Camera HDINCNIANNC
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
			[Cpp2IlInjected.Address(RVA = "0x1764220", Offset = "0x1763420", VA = "0x181764220")]
			public ColorConfiguration(ParticleSystem BMHGJEDMKIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x27E09C0", Offset = "0x27DFBC0", VA = "0x1827E09C0")]
			public void ECEJEECBNOD(Color JGDHNJNCLMJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class OBNEJPFBKOK : IEnumerator<NABEINJFOOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private NABEINJFOOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private CILFCLIHNND <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private NABEINJFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5FF480", Offset = "0x5FE680", VA = "0x1805FF480")]
			[DebuggerHidden]
			public OBNEJPFBKOK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x27E2130", Offset = "0x27E1330", VA = "0x1827E2130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x27E2B40", Offset = "0x27E1D40", VA = "0x1827E2B40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class DHBNPJBDIHH : IEnumerator<NABEINJFOOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private NABEINJFOOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private NABEINJFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5FF480", Offset = "0x5FE680", VA = "0x1805FF480")]
			[DebuggerHidden]
			public DHBNPJBDIHH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x27E0BD0", Offset = "0x27DFDD0", VA = "0x1827E0BD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x27E0C90", Offset = "0x27DFE90", VA = "0x1827E0C90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> JJGFKBCPAOM;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static List<PooledParticle> OOAOPCHDBAG;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static NNDKFCLIIOJ KAEIFBGNIOK;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const float MKLCLLDDCBB = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static bool LNJLEGKKEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		protected int EHKCPJEBANK;

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
		private ParticleSystem.MinMaxGradient[] GNNANDMCCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool OCNIAAMPAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float LBLBBFLLPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float LDGFBGOMHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Transform OJNLEFIAGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Vector3 ONHAAINGKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private Vector3 FMCDHMFAJAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private IAEFNCAEJAI PKBGNFLIELI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NNDKFCLIIOJ KHOLDHIMOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected bool BOLNINNEHMH;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected static bool GADEEBLKDMG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x27E4250", Offset = "0x27E3450", VA = "0x1827E4250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ParticleSystem CHIJMMILOED
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6FD450", Offset = "0x6FC650", VA = "0x1806FD450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ParticleSystem[] CCNDDHJKDGD
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x734270", Offset = "0x733470", VA = "0x180734270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7D6460", Offset = "0x7D5660", VA = "0x1807D6460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private ParticleSystemRenderer[] KPLDCIDAINM
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6FCDA0", Offset = "0x6FBFA0", VA = "0x1806FCDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6FD080", Offset = "0x6FC280", VA = "0x1806FD080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private IAEFNCAEJAI MPEBNODECNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9A48C0", Offset = "0x9A3AC0", VA = "0x1809A48C0")]
			get
			{
				return default(IAEFNCAEJAI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x27E4480", Offset = "0x27E3680", VA = "0x1827E4480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LBNOLOCNDPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x27E63B0", Offset = "0x27E55B0", VA = "0x1827E63B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x27E6450", Offset = "0x27E5650", VA = "0x1827E6450")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x27E6050", Offset = "0x27E5250", VA = "0x1827E6050")]
		public static PooledParticle TryPlayPrefab(PooledParticle DBHBBNPKELE, Vector3 BCCJFEBGGPE, Quaternion PAOOIKIKMBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x27E5E60", Offset = "0x27E5060", VA = "0x1827E5E60")]
		public static PooledParticle TryPlayPrefab(PooledParticle DBHBBNPKELE, Vector3 BCCJFEBGGPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x27E56A0", Offset = "0x27E48A0", VA = "0x1827E56A0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x27E47B0", Offset = "0x27E39B0", VA = "0x1827E47B0")]
		private void NBBFDCGJPPJ(bool KNNIGCHOJNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x27E4200", Offset = "0x27E3400", VA = "0x1827E4200")]
		[IteratorStateMachine(typeof(OBNEJPFBKOK))]
		private static IEnumerator<NABEINJFOOA> HHPIIJMMKMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x27E4830", Offset = "0x27E3A30", VA = "0x1827E4830")]
		protected void OPICBELEAIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x27E39C0", Offset = "0x27E2BC0", VA = "0x1827E39C0")]
		protected void CGPPHKNNMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x27E37D0", Offset = "0x27E29D0", VA = "0x1827E37D0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x27E44A0", Offset = "0x27E36A0", VA = "0x1827E44A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x27E49B0", Offset = "0x27E3BB0", VA = "0x1827E49B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x27E4180", Offset = "0x27E3380", VA = "0x1827E4180")]
		[IteratorStateMachine(typeof(DHBNPJBDIHH))]
		private IEnumerator<NABEINJFOOA> GNOPIKGIKON(float ELNGDGGHACP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x27E4A30", Offset = "0x27E3C30", VA = "0x1827E4A30")]
		private void PLGIPNAJDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x27E5C40", Offset = "0x27E4E40", VA = "0x1827E5C40")]
		public void SetDuration(float ELNGDGGHACP, bool IKBBIIDGGFF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x27E5400", Offset = "0x27E4600", VA = "0x1827E5400")]
		public void Play(Transform FFJJAFIGFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x27E5270", Offset = "0x27E4470", VA = "0x1827E5270")]
		public void Play(Transform FFJJAFIGFHL, bool LPPMKMLLALM, float IIJGIJFCGGM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x27E4EE0", Offset = "0x27E40E0", VA = "0x1827E4EE0")]
		public void Play(Transform FFJJAFIGFHL, Vector3 FMCDHMFAJAG, bool LPPMKMLLALM, float IIJGIJFCGGM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x27E4C90", Offset = "0x27E3E90", VA = "0x1827E4C90")]
		public void Play(Transform CKLOOMJCPHD, Quaternion PAOOIKIKMBJ, bool LPPMKMLLALM = false, float IIJGIJFCGGM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x27E5030", Offset = "0x27E4230", VA = "0x1827E5030")]
		public void Play(Transform CKLOOMJCPHD, Vector3 FMCDHMFAJAG, Quaternion PAOOIKIKMBJ, bool LPPMKMLLALM = false, float IIJGIJFCGGM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x27E4E10", Offset = "0x27E4010", VA = "0x1827E4E10")]
		public void Play(Vector3 BCCJFEBGGPE, Quaternion PAOOIKIKMBJ, Vector3 HMLDKLDKMPP, bool LPPMKMLLALM = false, float IIJGIJFCGGM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x27E4BD0", Offset = "0x27E3DD0", VA = "0x1827E4BD0")]
		public void Play(Vector3 BCCJFEBGGPE, Quaternion PAOOIKIKMBJ, bool LPPMKMLLALM = false, float IIJGIJFCGGM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x27E5160", Offset = "0x27E4360", VA = "0x1827E5160")]
		public void Play(bool LPPMKMLLALM = false, float IIJGIJFCGGM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x27E5DD0", Offset = "0x27E4FD0", VA = "0x1827E5DD0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x27E5D20", Offset = "0x27E4F20", VA = "0x1827E5D20")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x27E4300", Offset = "0x27E3500", VA = "0x1827E4300")]
		private void KDANBIIPDNB(float ELNGDGGHACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x27E3E70", Offset = "0x27E3070", VA = "0x1827E3E70")]
		private void FBEFOHJEIJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x27E5580", Offset = "0x27E4780", VA = "0x1827E5580")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x27E5820", Offset = "0x27E4A20", VA = "0x1827E5820")]
		public void SetColor(Color JGDHNJNCLMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x27E3FE0", Offset = "0x27E31E0", VA = "0x1827E3FE0")]
		private void FHELHGPKKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x27E6320", Offset = "0x27E5520", VA = "0x1827E6320")]
		public PooledParticle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x27E4780", Offset = "0x27E3980", VA = "0x1827E4780")]
		[CompilerGenerated]
		private void MIKONPGPNNI(ParticleSystemRenderer KGGCCPBPPIO)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class INAFFMAFPID
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static byte[] JIMOKIHBHOH;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static int FMDPFNLECKI;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static int AONCPEEEHKG;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static BigInteger ILKJFGLFAMB;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public INAFFMAFPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x27E1E70", Offset = "0x27E1070", VA = "0x1827E1E70")]
	private static string JBPNMHMEPIE(byte[] KLGGEDCBMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x27E1B40", Offset = "0x27E0D40", VA = "0x1827E1B40")]
	public static string HDPEGNHHKLG(byte[] FAOJAOEJLMO, bool CGIGAMOFOGM)
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
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
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
