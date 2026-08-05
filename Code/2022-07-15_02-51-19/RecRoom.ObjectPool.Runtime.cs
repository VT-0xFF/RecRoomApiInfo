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
		[Cpp2IlInjected.Address(RVA = "0x519E1E0", Offset = "0x519D1E0", VA = "0x18519E1E0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles PCLKDEOJIAH, float NILCACIBLGC, Vector3 PFANDEKBLGD, Quaternion OHIFHLJPHJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x519DF50", Offset = "0x519CF50", VA = "0x18519DF50")]
		public void SetDamageValue(float NILCACIBLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x519E380", Offset = "0x519D380", VA = "0x18519E380")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MILNAKLDHAN<T> : global::BDGKEGGAANF<T>, GNLNKOKJLFP, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KBCJLDKJLCF<T> : GNLNKOKJLFP, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PAJDMBPJIJG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EPNHIAONMGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class BPBNBAAACMM<T> : global::ADIAEJHDLBD<T>, global::MILNAKLDHAN<T>, global::BDGKEGGAANF<T>, GNLNKOKJLFP, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JEIBGGIOEOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public BPBNBAAACMM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
			public JEIBGGIOEOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3EBAA50", Offset = "0x3EB9A50", VA = "0x183EBAA50")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x37B67A0", Offset = "0x37B57A0", VA = "0x1837B67A0")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::HBBFIHNFHKG<T> GDGJPDKHEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool BIBPFJDHPBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T FHBJCKJIPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool OPPEGHNMEKD;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3EB0720", Offset = "0x3EAF720", VA = "0x183EB0720")]
		public BPBNBAAACMM(global::HBBFIHNFHKG<T> GDGJPDKHEGG, ObjectPool BIBPFJDHPBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3EB05E0", Offset = "0x3EAF5E0", VA = "0x183EB05E0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class GCDPGLHCHHL<T> : IHNBEKDFILG, global::KBCJLDKJLCF<T>, GNLNKOKJLFP, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class DEOMPGBHLCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public GCDPGLHCHHL<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
			public DEOMPGBHLCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0E90", Offset = "0x3EAFE90", VA = "0x183EB0E90")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x10CE670", Offset = "0x10CD670", VA = "0x1810CE670")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::HBBFIHNFHKG<T> GDGJPDKHEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool OPPEGHNMEKD;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA810", Offset = "0x3EB9810", VA = "0x183EBA810")]
		public GCDPGLHCHHL(global::HBBFIHNFHKG<T> GDGJPDKHEGG, ObjectPool BIBPFJDHPBB, int CMHHELKHPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA7C0", Offset = "0x3EB97C0", VA = "0x183EBA7C0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CAJCPDICPLB<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EPNHIAONMGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::ADIAEJHDLBD<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::HBBFIHNFHKG<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public CAJCPDICPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3EB0950", Offset = "0x3EAF950", VA = "0x183EB0950")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB09E0", Offset = "0x3EAF9E0", VA = "0x183EB09E0")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3EB0A40", Offset = "0x3EAFA40", VA = "0x183EB0A40")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<PAJDMBPJIJG> NDNHCJBNPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private MAHAPDMMPJP JIFDJILPFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool BIBPFJDHPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool OPPEGHNMEKD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool JNKLHCNGBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x519BB80", Offset = "0x519AB80", VA = "0x18519BB80")]
	private static void KBLKOFNPAGJ(Component HMHKKCGCCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x519BDE0", Offset = "0x519ADE0", VA = "0x18519BDE0")]
	public EPNHIAONMGD(string DOBBKFLDEHC, int PCMPKHJLBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1FD46B0", Offset = "0x1FD36B0", VA = "0x181FD46B0")]
	public global::MILNAKLDHAN<T> OKDDLGJCBOH<T>(AssetReference HODFAMCGDBK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4740", Offset = "0x1FD3740", VA = "0x181FD4740")]
	public global::KBCJLDKJLCF<T> PHGBKOJIBEA<T>(AssetReference HODFAMCGDBK, int GLCMJLMDOEH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1EDDC80", Offset = "0x1EDCC80", VA = "0x181EDDC80")]
	public global::BDGKEGGAANF<bool> MOEJJIDPMEJ<T>(AssetReference HODFAMCGDBK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x519B940", Offset = "0x519A940", VA = "0x18519B940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x519BA50", Offset = "0x519AA50", VA = "0x18519BA50")]
	private void JLJLJCLPHAE(UnityEngine.Object PJCJJKDNBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x519B7F0", Offset = "0x519A7F0", VA = "0x18519B7F0")]
	private ObjectPool APMOANCAOMG(string DOBBKFLDEHC)
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
		private static GlobalPool MLPBMJIMCKG;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject BANBEMBKOPI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool AOMOPIPEMFB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x519C150", Offset = "0x519B150", VA = "0x18519C150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x519C000", Offset = "0x519B000", VA = "0x18519C000")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x519C0E0", Offset = "0x519B0E0", VA = "0x18519C0E0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, JFIEHHMFAOG> JJGHPOOMGLK;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1F75220", Offset = "0x1F74220", VA = "0x181F75220")]
		public T Acquire<T>(T PCLKDEOJIAH, [Optional] Action<Component> MHJOEOCKMIA) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x26D7540", Offset = "0x26D6540", VA = "0x1826D7540")]
		public bool Release<T>(T NHBCHHMAJOK) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1BFBAD0", Offset = "0x1BFAAD0", VA = "0x181BFBAD0")]
		public void Prefill<T>(T PCLKDEOJIAH, int HNOIICFALON, [Optional] Action<Component> MDEAFINLMCP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x26D74A0", Offset = "0x26D64A0", VA = "0x1826D74A0")]
		public bool Exists<T>(T PCLKDEOJIAH) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1BFBA30", Offset = "0x1BFAA30", VA = "0x181BFBA30")]
		public void Clear<T>(T PCLKDEOJIAH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x519DB70", Offset = "0x519CB70", VA = "0x18519DB70")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5860", Offset = "0x1FE4860", VA = "0x181FE5860")]
		private JFIEHHMFAOG KKLDNDAHIDN<T>(T PCLKDEOJIAH) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80")]
		public void TrackInstantiation(string IGMOENPBGMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80")]
		public void EnableStats(bool OELAHLFGICO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x519C0E0", Offset = "0x519B0E0", VA = "0x18519C0E0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class JFIEHHMFAOG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface JAPNOLGPHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EOEBALCANNA(bool MIJGBGDJCEE);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component BOEELLCEGOL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string ADLJMBIPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int CBHMECACBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void PHGBKOJIBEA(int GLCMJLMDOEH, Action<Component> MDEAFINLMCP);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component OKDDLGJCBOH(Action<Component> MHJOEOCKMIA);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool PFDGBAGNHGC(Component MADHPHKBBEN);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void ABPOABCICEP();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x519C9E0", Offset = "0x519B9E0", VA = "0x18519C9E0")]
	protected void FGONIJILJIM(Component NHBCHHMAJOK, bool MIJGBGDJCEE, bool GEOBKCKJFGE, bool GFELPACAMGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x519CB60", Offset = "0x519BB60", VA = "0x18519CB60")]
	protected void LLCDDJAINKN(Transform CNMOCOAAHMN, bool MIJGBGDJCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	protected JFIEHHMFAOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FJODCMKBJNP<T> : JFIEHHMFAOG where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T PCLKDEOJIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool LMPAABLCJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool GEOBKCKJFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> FFKCCNEIAFP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component BOEELLCEGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string ADLJMBIPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x41E12F0", Offset = "0x41E02F0", VA = "0x1841E12F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int CBHMECACBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x41E1310", Offset = "0x41E0310", VA = "0x1841E1310", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x41E1810", Offset = "0x41E0810", VA = "0x1841E1810")]
	public FJODCMKBJNP(T PCLKDEOJIAH, ObjectPool LMPAABLCJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x41E1700", Offset = "0x41E0700", VA = "0x1841E1700", Slot = "7")]
	public override void PHGBKOJIBEA(int GLCMJLMDOEH, Action<Component> MHJOEOCKMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x41E1340", Offset = "0x41E0340", VA = "0x1841E1340", Slot = "8")]
	public override Component OKDDLGJCBOH(Action<Component> MHJOEOCKMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x41E1570", Offset = "0x41E0570", VA = "0x1841E1570", Slot = "9")]
	public override bool PFDGBAGNHGC(Component MADHPHKBBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x41E0F60", Offset = "0x41DFF60", VA = "0x1841E0F60", Slot = "10")]
	public override void ABPOABCICEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x41E11A0", Offset = "0x41E01A0", VA = "0x1841E11A0")]
	private T BCBGMAGOOGB()
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
		public interface LBJKJKMCGNH
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject JFOENPCMFAG
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
		[Cpp2IlInjected.Address(RVA = "0x519D820", Offset = "0x519C820", VA = "0x18519D820")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x519DB00", Offset = "0x519CB00", VA = "0x18519DB00")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool MLPBMJIMCKG;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject BANBEMBKOPI;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool AOMOPIPEMFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x519DD90", Offset = "0x519CD90", VA = "0x18519DD90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x519DCB0", Offset = "0x519CCB0", VA = "0x18519DCB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x519C0E0", Offset = "0x519B0E0", VA = "0x18519C0E0")]
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
		public JFIEHHMFAOG PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public PooledObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private enum DCJCMHBNAIL
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
		public interface OCOFGEKACMK
		{
			[Cpp2IlInjected.Token(Token = "0x17000010")]
			bool GHLIENNNLLM
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			Vector3 GAOHDPCMGCC
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Camera LECLFNPKLOB
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
			[Cpp2IlInjected.Address(RVA = "0xA1B900", Offset = "0xA1A900", VA = "0x180A1B900")]
			public ColorConfiguration(ParticleSystem CKOKMPPMPPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x519B5E0", Offset = "0x519A5E0", VA = "0x18519B5E0")]
			public void FOLEDCEJOIH(Color OPIICEOPPKJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class NDGPLIJBBEB : IEnumerator<HGLMJIKIMPH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private HGLMJIKIMPH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private OCOFGEKACMK <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private HGLMJIKIMPH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x69E7D0", Offset = "0x69D7D0", VA = "0x18069E7D0")]
			[DebuggerHidden]
			public NDGPLIJBBEB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x519CD50", Offset = "0x519BD50", VA = "0x18519CD50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x519D7D0", Offset = "0x519C7D0", VA = "0x18519D7D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class IEBNFEEMOLF : IEnumerator<HGLMJIKIMPH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private HGLMJIKIMPH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private HGLMJIKIMPH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x69E7D0", Offset = "0x69D7D0", VA = "0x18069E7D0")]
			[DebuggerHidden]
			public IEBNFEEMOLF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x519C2E0", Offset = "0x519B2E0", VA = "0x18519C2E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x519C3A0", Offset = "0x519B3A0", VA = "0x18519C3A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> CDMHDJAFEAK;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static List<PooledParticle> AGOHOLHMGPD;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static ELHLMKINOCP NCELOOLKFEI;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const float ODEBDCMKNNK = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static bool BBPCMPPLGCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		protected int DJDJIOJNEJO;

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
		private ParticleSystem.MinMaxGradient[] EBOEHGMKMKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool NMIEIAAEFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float BOPAMJPAODI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float OHPNDBIOLJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Transform LBEFFIFDJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Vector3 FMDMLJDNHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private Vector3 IEHDPPDHODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private DCJCMHBNAIL GGPBLEPDDOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ELHLMKINOCP JEBEBLINLIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected bool GFOLHIPKPCN;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected static bool OFBMFPCEMAO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x519F4C0", Offset = "0x519E4C0", VA = "0x18519F4C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ParticleSystem AAKMCHMJHEF
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5B60C0", Offset = "0x5B50C0", VA = "0x1805B60C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6B0CC0", Offset = "0x6AFCC0", VA = "0x1806B0CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ParticleSystem[] PFBPOJAEOGB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5B5A30", Offset = "0x5B4A30", VA = "0x1805B5A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6C5580", Offset = "0x6C4580", VA = "0x1806C5580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private ParticleSystemRenderer[] GHPFBMJFKJK
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x58E010", Offset = "0x58D010", VA = "0x18058E010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x58E020", Offset = "0x58D020", VA = "0x18058E020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DCJCMHBNAIL LAOBAMDJGGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x658380", Offset = "0x657380", VA = "0x180658380")]
			get
			{
				return default(DCJCMHBNAIL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x519F140", Offset = "0x519E140", VA = "0x18519F140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action DEAOGBJMFPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x51A1040", Offset = "0x51A0040", VA = "0x1851A1040")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x51A10E0", Offset = "0x51A00E0", VA = "0x1851A10E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x51A0CE0", Offset = "0x519FCE0", VA = "0x1851A0CE0")]
		public static PooledParticle TryPlayPrefab(PooledParticle PCLKDEOJIAH, Vector3 PFANDEKBLGD, Quaternion OHIFHLJPHJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x51A0AF0", Offset = "0x519FAF0", VA = "0x1851A0AF0")]
		public static PooledParticle TryPlayPrefab(PooledParticle PCLKDEOJIAH, Vector3 PFANDEKBLGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x51A0330", Offset = "0x519F330", VA = "0x1851A0330")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x519F570", Offset = "0x519E570", VA = "0x18519F570")]
		private void OEHNBIDGHFP(bool KJNKDJNAEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x519F5F0", Offset = "0x519E5F0", VA = "0x18519F5F0")]
		[IteratorStateMachine(typeof(NDGPLIJBBEB))]
		private static IEnumerator<HGLMJIKIMPH> OOKGPNGCOJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x519ECA0", Offset = "0x519DCA0", VA = "0x18519ECA0")]
		protected void GFHOPAEMGPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x519E680", Offset = "0x519D680", VA = "0x18519E680")]
		protected void EOMFIBDFBEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x519E460", Offset = "0x519D460", VA = "0x18519E460", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x519F160", Offset = "0x519E160", VA = "0x18519F160")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x519F640", Offset = "0x519E640", VA = "0x18519F640")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x519F440", Offset = "0x519E440", VA = "0x18519F440")]
		[IteratorStateMachine(typeof(IEBNFEEMOLF))]
		private IEnumerator<HGLMJIKIMPH> MOIBIOAHEEA(float JAHEPLOODHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x519F6C0", Offset = "0x519E6C0", VA = "0x18519F6C0")]
		private void PFDGBAGNHGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x51A08D0", Offset = "0x519F8D0", VA = "0x1851A08D0")]
		public void SetDuration(float JAHEPLOODHL, bool HIFLICOCCEA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x51A0090", Offset = "0x519F090", VA = "0x1851A0090")]
		public void Play(Transform DHNPBJNHABC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x519FF00", Offset = "0x519EF00", VA = "0x18519FF00")]
		public void Play(Transform DHNPBJNHABC, bool OBFHEDDGIJK, float GNEJFADIFJD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x519FB70", Offset = "0x519EB70", VA = "0x18519FB70")]
		public void Play(Transform DHNPBJNHABC, Vector3 IEHDPPDHODD, bool OBFHEDDGIJK, float GNEJFADIFJD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x519F920", Offset = "0x519E920", VA = "0x18519F920")]
		public void Play(Transform PPFDPFLICAH, Quaternion OHIFHLJPHJJ, bool OBFHEDDGIJK = false, float GNEJFADIFJD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x519FCC0", Offset = "0x519ECC0", VA = "0x18519FCC0")]
		public void Play(Transform PPFDPFLICAH, Vector3 IEHDPPDHODD, Quaternion OHIFHLJPHJJ, bool OBFHEDDGIJK = false, float GNEJFADIFJD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x519FAA0", Offset = "0x519EAA0", VA = "0x18519FAA0")]
		public void Play(Vector3 PFANDEKBLGD, Quaternion OHIFHLJPHJJ, Vector3 EIBPINMHIFE, bool OBFHEDDGIJK = false, float GNEJFADIFJD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x519F860", Offset = "0x519E860", VA = "0x18519F860")]
		public void Play(Vector3 PFANDEKBLGD, Quaternion OHIFHLJPHJJ, bool OBFHEDDGIJK = false, float GNEJFADIFJD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x519FDF0", Offset = "0x519EDF0", VA = "0x18519FDF0")]
		public void Play(bool OBFHEDDGIJK = false, float GNEJFADIFJD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x51A0A60", Offset = "0x519FA60", VA = "0x1851A0A60")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x51A09B0", Offset = "0x519F9B0", VA = "0x1851A09B0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x519EE20", Offset = "0x519DE20", VA = "0x18519EE20")]
		private void IBCAFMBBKOA(float JAHEPLOODHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x519EB30", Offset = "0x519DB30", VA = "0x18519EB30")]
		private void FBIPIFJIBFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x51A0210", Offset = "0x519F210", VA = "0x1851A0210")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x51A04B0", Offset = "0x519F4B0", VA = "0x1851A04B0")]
		public void SetColor(Color OPIICEOPPKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x519EFA0", Offset = "0x519DFA0", VA = "0x18519EFA0")]
		private void JLBGBMDIPAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x51A0FB0", Offset = "0x519FFB0", VA = "0x1851A0FB0")]
		public PooledParticle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x519E650", Offset = "0x519D650", VA = "0x18519E650")]
		[CompilerGenerated]
		private void DNNIBMMAPJP(ParticleSystemRenderer ENOLGCPGGLO)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IPBFNGMPFEA
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static byte[] FDFKLIHCMDI;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static int IKEJBHOADAH;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static int BADMEAGLBCG;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static BigInteger LKFKJFPDNAJ;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public IPBFNGMPFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x519C3F0", Offset = "0x519B3F0", VA = "0x18519C3F0")]
	private static string OJNKOKJGCOH(byte[] BMEGDOGJIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x519C4F0", Offset = "0x519B4F0", VA = "0x18519C4F0")]
	public static string PLNHDMOHEMF(byte[] LNCIHJHIBKD, bool PDPJHLLFJEO)
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
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
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
